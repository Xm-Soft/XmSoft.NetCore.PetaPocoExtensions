using Microsoft.Extensions.Options;
using PetaPoco;

namespace XmSoft.NetCore.PetaPocoExtensions
{
    /// <summary>
    /// 
    /// </summary>
    public class PetaPocoDBContextOptions : IOptions<PetaPocoDBContextOptions>
    {
        /// <summary>The default configured TOptions instance</summary>
        PetaPocoDBContextOptions IOptions<PetaPocoDBContextOptions>.Value => this;
        /// <summary>
        /// 数据库连接
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string ProviderName { get; set; }
    }
    /// <summary>
    /// PetaPoco DBContext Configuration
    /// </summary>
    public class PetaPocoDBContextConfigurationOptions : IOptions<PetaPocoDBContextConfigurationOptions>
    {
        /// <summary>The default configured TOptions instance</summary>
        PetaPocoDBContextConfigurationOptions IOptions<PetaPocoDBContextConfigurationOptions>.Value => this;

        /// <summary>
        /// 
        /// </summary>
        public IDatabaseBuildConfiguration Configuration { get; set; }
    }
}
