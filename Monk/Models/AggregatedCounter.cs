﻿using System;
using System.Linq;
using System.Text;

namespace Monk.Models
{
    public class AggregatedCounter
    {
        
				///<summary>
                /// 描述：-
                /// 默认值：-
                /// 可空：False
				/// </summary>
		         public int Id {get;set;}

				///<summary>
                /// 描述：-
                /// 默认值：-
                /// 可空：False
				/// </summary>
		         public string Key {get;set;}

				///<summary>
                /// 描述：-
                /// 默认值：-
                /// 可空：False
				/// </summary>
		         public Int64 Value {get;set;}

				///<summary>
                /// 描述：-
                /// 默认值：-
                /// 可空：True
				/// </summary>
		         public DateTime? ExpireAt {get;set;}

    }
}
