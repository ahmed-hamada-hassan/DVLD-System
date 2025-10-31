using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.TestTypes
{
    public class ClsTestTypeMapper
    {
        public static ClsTestType MapToClsTestType(SqlDataReader Reader)
        {
            int TestTypeIDOrdinal = Reader.GetOrdinal("TestTypeID");
            int TestTypeTitleOrdinal = Reader.GetOrdinal("TestTypeTitle");
            int TestTypeDescriptionOrdinal = Reader.GetOrdinal("TestTypeDescription");
            int TestTypeFeesOrdinal = Reader.GetOrdinal("TestTypeFees");

            return new ClsTestType
            {
                TestTypeID = Reader.GetInt32(TestTypeIDOrdinal),
                TestTypeTitle = Reader.GetString(TestTypeTitleOrdinal),
                TestTypeDescription = Reader.GetString(TestTypeDescriptionOrdinal),
                TestTypeFees = Reader.GetDecimal(TestTypeFeesOrdinal)
            };
        }
    }
}
