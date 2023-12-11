namespace Blueprint.Demo.Models
{
    public class Node
    {
        public string Name { get; set; } = "";

        /// <summary>
        /// 本节点唯一标识
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// 输入插座
        /// </summary>
        public Dictionary<string, Guid> SocketIn { get; set; } = [];

        /// <summary>
        /// 输出插座
        /// </summary>
        public Dictionary<string, Guid> SocketOut { get; set; } = [];


    }
}
