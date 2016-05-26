using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;

namespace JSDY.U9SV.Utils
{
    /// <summary>
    /// 主键构造器
    /// </summary>
    public class KeyBuilder
    {
        public static long CreateKey()
        {
            List<long> keys = CreateKeys(1);
            if (keys == null || keys.Count == 0) return 0;
            return keys[0];
        }

        public static List<long> CreateKeys(int count)
        {
            if (count <= 0)
                throw new ArgumentException("参数count非法");

            string sql = string.Format(@"
declare	@SNIndex bigint
exec [dbo].[AllocSerials] {0}, @SNIndex output
select @SNIndex as ID", count);
            object value = SQLHelper.ExecuteScalar(sql);
            long firstKey = TypeHelper.ConvertType<long>(value, 0);
            List<long> keys = new List<long>();

            for (int i = 0; i < count; i++)
            {
                keys.Add(firstKey);
                firstKey++;
            }

            return keys;
        }
    }
}
