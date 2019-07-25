
using Microsoft.Extensions.Options;
using PetaPoco;

namespace XmSoft.NetCore.PetaPocoExtensions
{
    /// <summary>
    /// PetaPoco DBContext
    /// </summary>
    public abstract class PetaPocoDBContext : Database, IPetaPocoDBContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="optionsAccessor"></param>
        protected PetaPocoDBContext(IOptions<PetaPocoDBContextOptions> optionsAccessor)
            : base(optionsAccessor.Value.ConnectionString, optionsAccessor.Value.ProviderName)
        {

        }
    }
    /// <summary>
    /// 
    /// </summary>
    public abstract class PetaPocoDBContextConfiguration : Database, IPetaPocoDBContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="optionsAccessor"></param>
        protected PetaPocoDBContextConfiguration(IOptions<PetaPocoDBContextConfigurationOptions> optionsAccessor)
            : base(optionsAccessor.Value.Configuration)
        {

        }
    }
}
