using ConsoleApp2.Entities;
using ConsoleApp2.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace ConsoleApp2
{
    public class DbUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"(local)\SQLEXPRESS";

            string database = "test";
            string username = "sa";
            string password = "123456789";

            return DbSqlServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static void AddOffer(SqlConnection connection, Offer offer)
        {
            IEnumerable<FieldInfo> fields = offer.GetType().GetTypeInfo().DeclaredFields;

            string sql = "InsertOffer";

            string ItemsElementName = string.Empty;
            string Items = string.Empty;

            foreach (var field in fields.Where(x => !x.IsStatic))
            {
                switch (field.Name)
                {
                    case "itemsField":
                        object[] ItemsFields = (object[])field.GetValue(offer);
                        foreach (var item in ItemsFields)
                        {

                            Items += item.ToString() + "|";
                        }
                        break;
                    case "itemsElementNameField":
                        ItemsChoiceType[] ItemsNames = (ItemsChoiceType[])field.GetValue(offer);
                        foreach (var item in ItemsNames)
                        {
                            ItemsElementName += item.ToString() + "|";
                        }
                        break;
                    default:
                        break;
                }

            }

            SqlCommand command = new SqlCommand(sql, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Id", offer.Id);
            command.Parameters.AddWithValue("@Type", offer.Type);
            command.Parameters.AddWithValue("@Bid", offer.Bid);
            command.Parameters.AddWithValue("@CBid", offer.CBid);
            command.Parameters.AddWithValue("@Available", offer.Available);
            command.Parameters.AddWithValue("@ItemsElementName", ItemsElementName);
            command.Parameters.AddWithValue("@Items", Items);

            var result = command.ExecuteScalar();
        }
    }
}
