using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hyyModel
{
    /// <summary>
    /// 武林高手
    /// </summary>
    public class MartialArtsMaster
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 门派
        /// </summary>
        public string Menpai { get; set; }
        /// <summary>
        /// 武学
        /// </summary>
        public string Kongfu { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public int Level { get; set; }

    }
}
