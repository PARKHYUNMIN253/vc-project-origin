// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using BizOneShot.Light.Models.WebModels;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace BizOneShot.Light.Dao.WebConfiguration
{
    // QUES_COMP_INFO
    internal partial class QuesCompInfoConfiguration : EntityTypeConfiguration<QuesCompInfo>
    {
        public QuesCompInfoConfiguration()
            : this("dbo")
        {
        }
 
        public QuesCompInfoConfiguration(string schema)
        {
            ToTable(schema + ".QUES_COMP_INFO");
            HasKey(x => x.QuestionSn);

            Property(x => x.QuestionSn).HasColumnName("QUESTION_SN").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CompNm).HasColumnName("COMP_NM").IsOptional().HasColumnType("nvarchar").HasMaxLength(70);
            Property(x => x.EngCompNm).HasColumnName("ENG_COMP_NM").IsOptional().HasColumnType("nvarchar").HasMaxLength(70);
            Property(x => x.TelNo).HasColumnName("TEL_NO").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.FaxNo).HasColumnName("FAX_NO").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Name).HasColumnName("NAME").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Email).HasColumnName("EMAIL").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.RegistrationNo).HasColumnName("REGISTRATION_NO").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.CoRegistrationNo).HasColumnName("CO_REGISTRATION_NO").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(15);
            Property(x => x.PublishDt).HasColumnName("PUBLISH_DT").IsOptional().HasColumnType("datetime");
            Property(x => x.HomeUrl).HasColumnName("HOME_URL").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.CompAddr).HasColumnName("COMP_ADDR").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.FactoryAddr).HasColumnName("FACTORY_ADDR").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.LabAddr).HasColumnName("LAB_ADDR").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.ProductNm1).HasColumnName("PRODUCT_NM1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ProductNm2).HasColumnName("PRODUCT_NM2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ProductNm3).HasColumnName("PRODUCT_NM3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.MarketPublic).HasColumnName("MARKET_PUBLIC").IsOptional().HasColumnType("bit");
            Property(x => x.MarketCivil).HasColumnName("MARKET_CIVIL").IsOptional().HasColumnType("bit");
            Property(x => x.MarketConsumer).HasColumnName("MARKET_CONSUMER").IsOptional().HasColumnType("bit");
            Property(x => x.MarketForeing).HasColumnName("MARKET_FOREING").IsOptional().HasColumnType("bit");
            Property(x => x.MarketEtc).HasColumnName("MARKET_ETC").IsOptional().HasColumnType("bit");
            Property(x => x.CompType).HasColumnName("COMP_TYPE").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.ResidentType).HasColumnName("RESIDENT_TYPE").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.CertiVenture).HasColumnName("CERTI_VENTURE").IsOptional().HasColumnType("bit");
            Property(x => x.CertiRnd).HasColumnName("CERTI_RND").IsOptional().HasColumnType("bit");
            Property(x => x.CertiMainbiz).HasColumnName("CERTI_MAINBIZ").IsOptional().HasColumnType("bit");
            Property(x => x.CertiInnobiz).HasColumnName("CERTI_INNOBIZ").IsOptional().HasColumnType("bit");
            Property(x => x.RegDt).HasColumnName("REG_DT").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdDt).HasColumnName("UPD_DT").IsOptional().HasColumnType("datetime");
            Property(x => x.CompLeaseYn).HasColumnName("COMP_LEASE_YN").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.FactoryLeaseYn).HasColumnName("FACTORY_LEASE_YN").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.LabLeaseYn).HasColumnName("LAB_LEASE_YN").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.StandardCode1).HasColumnName("STANDARD_CODE1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5);
            Property(x => x.StandardCode2).HasColumnName("STANDARD_CODE2").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.StandardCode3).HasColumnName("STANDARD_CODE3").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(7);
            Property(x => x.MainSellMarket).HasColumnName("MAIN_SELL_MARKET").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CertiRoot).HasColumnName("CERTI_ROOT").IsOptional().HasColumnType("bit");
            Property(x => x.CertiGreen).HasColumnName("CERTI_GREEN").IsOptional().HasColumnType("bit");
            Property(x => x.CertiWoman).HasColumnName("CERTI_WOMAN").IsOptional().HasColumnType("bit");
            Property(x => x.CertiSocial).HasColumnName("CERTI_SOCIAL").IsOptional().HasColumnType("bit");
            Property(x => x.CertiEtc).HasColumnName("CERTI_ETC").IsOptional().HasColumnType("bit");
            Property(x => x.NumSn).HasColumnName("NUM_SN").IsOptional().HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.MarketEtcText).HasColumnName("MARKET_ETC_TEXT").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.CertiEtcText).HasColumnName("CERTI_ETC_TEXT").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.ResidentEtc).HasColumnName("RESIDENT_ETC").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.TcmsLoginKey).HasColumnName("TCMS_LOGIN_KEY").IsOptional().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.QuesMaster).WithOptional(b => b.QuesCompInfo); // FK_QUES_MASTER_TO_QUES_COMP_INFO
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
