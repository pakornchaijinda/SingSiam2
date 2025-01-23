using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SingSiamOffice.Models.SingSiamOld2;

public partial class _02singsiamContext : DbContext
{
    public _02singsiamContext()
    {
    }

    public _02singsiamContext(DbContextOptions<_02singsiamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Blacklist> Blacklists { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Closeconfig> Closeconfigs { get; set; }

    public virtual DbSet<Config> Configs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Expincome> Expincomes { get; set; }

    public virtual DbSet<Externalar> Externalars { get; set; }

    public virtual DbSet<ExternalarDetail> ExternalarDetails { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Lateconfig> Lateconfigs { get; set; }

    public virtual DbSet<Logfile201301> Logfile201301s { get; set; }

    public virtual DbSet<Logfile201701> Logfile201701s { get; set; }

    public virtual DbSet<Logfile201712> Logfile201712s { get; set; }

    public virtual DbSet<Logfile201801> Logfile201801s { get; set; }

    public virtual DbSet<Logfile201802> Logfile201802s { get; set; }

    public virtual DbSet<Logfile201803> Logfile201803s { get; set; }

    public virtual DbSet<Logfile201804> Logfile201804s { get; set; }

    public virtual DbSet<Logfile201805> Logfile201805s { get; set; }

    public virtual DbSet<Logfile201806> Logfile201806s { get; set; }

    public virtual DbSet<Logfile201807> Logfile201807s { get; set; }

    public virtual DbSet<Logfile201808> Logfile201808s { get; set; }

    public virtual DbSet<Logfile201809> Logfile201809s { get; set; }

    public virtual DbSet<Logfile201810> Logfile201810s { get; set; }

    public virtual DbSet<Logfile201811> Logfile201811s { get; set; }

    public virtual DbSet<Logfile201812> Logfile201812s { get; set; }

    public virtual DbSet<Logfile201901> Logfile201901s { get; set; }

    public virtual DbSet<Logfile201902> Logfile201902s { get; set; }

    public virtual DbSet<Logfile201903> Logfile201903s { get; set; }

    public virtual DbSet<Logfile201904> Logfile201904s { get; set; }

    public virtual DbSet<Logfile201905> Logfile201905s { get; set; }

    public virtual DbSet<Logfile201906> Logfile201906s { get; set; }

    public virtual DbSet<Logfile201907> Logfile201907s { get; set; }

    public virtual DbSet<Logfile201908> Logfile201908s { get; set; }

    public virtual DbSet<Logfile201909> Logfile201909s { get; set; }

    public virtual DbSet<Logfile201910> Logfile201910s { get; set; }

    public virtual DbSet<Logfile201911> Logfile201911s { get; set; }

    public virtual DbSet<Logfile201912> Logfile201912s { get; set; }

    public virtual DbSet<Logfile202001> Logfile202001s { get; set; }

    public virtual DbSet<Logfile202002> Logfile202002s { get; set; }

    public virtual DbSet<Logfile202003> Logfile202003s { get; set; }

    public virtual DbSet<Logfile202004> Logfile202004s { get; set; }

    public virtual DbSet<Logfile202005> Logfile202005s { get; set; }

    public virtual DbSet<Logfile202006> Logfile202006s { get; set; }

    public virtual DbSet<Logfile202007> Logfile202007s { get; set; }

    public virtual DbSet<Logfile202008> Logfile202008s { get; set; }

    public virtual DbSet<Logfile202009> Logfile202009s { get; set; }

    public virtual DbSet<Logfile202010> Logfile202010s { get; set; }

    public virtual DbSet<Logfile202011> Logfile202011s { get; set; }

    public virtual DbSet<Logfile202012> Logfile202012s { get; set; }

    public virtual DbSet<Logfile202101> Logfile202101s { get; set; }

    public virtual DbSet<Logfile202102> Logfile202102s { get; set; }

    public virtual DbSet<Logfile202103> Logfile202103s { get; set; }

    public virtual DbSet<Logfile202104> Logfile202104s { get; set; }

    public virtual DbSet<Logfile202105> Logfile202105s { get; set; }

    public virtual DbSet<Logfile202106> Logfile202106s { get; set; }

    public virtual DbSet<Logfile202107> Logfile202107s { get; set; }

    public virtual DbSet<Logfile202108> Logfile202108s { get; set; }

    public virtual DbSet<Logfile202109> Logfile202109s { get; set; }

    public virtual DbSet<Logfile202110> Logfile202110s { get; set; }

    public virtual DbSet<Logfile202111> Logfile202111s { get; set; }

    public virtual DbSet<Logfile202112> Logfile202112s { get; set; }

    public virtual DbSet<Logfile202201> Logfile202201s { get; set; }

    public virtual DbSet<Logfile202202> Logfile202202s { get; set; }

    public virtual DbSet<Logfile202203> Logfile202203s { get; set; }

    public virtual DbSet<Logfile202204> Logfile202204s { get; set; }

    public virtual DbSet<Logfile202205> Logfile202205s { get; set; }

    public virtual DbSet<Logfile202206> Logfile202206s { get; set; }

    public virtual DbSet<Logfile202207> Logfile202207s { get; set; }

    public virtual DbSet<Logfile202208> Logfile202208s { get; set; }

    public virtual DbSet<Logfile202209> Logfile202209s { get; set; }

    public virtual DbSet<Logfile202210> Logfile202210s { get; set; }

    public virtual DbSet<Logfile202211> Logfile202211s { get; set; }

    public virtual DbSet<Logfile202212> Logfile202212s { get; set; }

    public virtual DbSet<Logfile202301> Logfile202301s { get; set; }

    public virtual DbSet<Logfile202302> Logfile202302s { get; set; }

    public virtual DbSet<Logfile202303> Logfile202303s { get; set; }

    public virtual DbSet<Logfile202304> Logfile202304s { get; set; }

    public virtual DbSet<Logfile202305> Logfile202305s { get; set; }

    public virtual DbSet<Logfile202306> Logfile202306s { get; set; }

    public virtual DbSet<Logfile202307> Logfile202307s { get; set; }

    public virtual DbSet<Logfile202308> Logfile202308s { get; set; }

    public virtual DbSet<Logfile202309> Logfile202309s { get; set; }

    public virtual DbSet<Logfile202310> Logfile202310s { get; set; }

    public virtual DbSet<Logfile202311> Logfile202311s { get; set; }

    public virtual DbSet<Logfile202312> Logfile202312s { get; set; }

    public virtual DbSet<Logfile202401> Logfile202401s { get; set; }

    public virtual DbSet<Logfile202402> Logfile202402s { get; set; }

    public virtual DbSet<Logfile202403> Logfile202403s { get; set; }

    public virtual DbSet<Logfile202404> Logfile202404s { get; set; }

    public virtual DbSet<Logfile202405> Logfile202405s { get; set; }

    public virtual DbSet<Logfile202406> Logfile202406s { get; set; }

    public virtual DbSet<Logfile202407> Logfile202407s { get; set; }

    public virtual DbSet<Logfile202408> Logfile202408s { get; set; }

    public virtual DbSet<Logfile202409> Logfile202409s { get; set; }

    public virtual DbSet<Logfile202410> Logfile202410s { get; set; }

    public virtual DbSet<Logfile202411> Logfile202411s { get; set; }

    public virtual DbSet<Logfile202412> Logfile202412s { get; set; }

    public virtual DbSet<Periodtran> Periodtrans { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promise> Promises { get; set; }

    public virtual DbSet<PromiseMemo> PromiseMemos { get; set; }

    public virtual DbSet<PromiseRemark> PromiseRemarks { get; set; }

    public virtual DbSet<Receiptdesc> Receiptdescs { get; set; }

    public virtual DbSet<ReceiptdescCancel> ReceiptdescCancels { get; set; }

    public virtual DbSet<Receipttran> Receipttrans { get; set; }

    public virtual DbSet<ReceipttranCancel> ReceipttranCancels { get; set; }

    public virtual DbSet<Reinterest> Reinterests { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Userfile> Userfiles { get; set; }

    public virtual DbSet<Userreport> Userreports { get; set; }

    public virtual DbSet<ZzLogfile> ZzLogfiles { get; set; }

    public virtual DbSet<ZzRaw1Cav> ZzRaw1Cavs { get; set; }

    public virtual DbSet<ZzRaw1Cbv> ZzRaw1Cbvs { get; set; }

    public virtual DbSet<ZzRaw1Ccv> ZzRaw1Ccvs { get; set; }

    public virtual DbSet<ZzRaw1Cdv> ZzRaw1Cdvs { get; set; }

    public virtual DbSet<ZzRaw1Cev> ZzRaw1Cevs { get; set; }

    public virtual DbSet<ZzRaw1Cfv> ZzRaw1Cfvs { get; set; }

    public virtual DbSet<ZzRaw1Cgv> ZzRaw1Cgvs { get; set; }

    public virtual DbSet<ZzRaw1Chv> ZzRaw1Chvs { get; set; }

    public virtual DbSet<ZzRaw1Civ> ZzRaw1Civs { get; set; }

    public virtual DbSet<ZzRaw1Cjv> ZzRaw1Cjvs { get; set; }

    public virtual DbSet<ZzRaw1Ckv> ZzRaw1Ckvs { get; set; }

    public virtual DbSet<ZzRaw1Clv> ZzRaw1Clvs { get; set; }

    public virtual DbSet<ZzRaw1Cmv> ZzRaw1Cmvs { get; set; }

    public virtual DbSet<ZzRaw1Cnv> ZzRaw1Cnvs { get; set; }

    public virtual DbSet<ZzRaw1Cov> ZzRaw1Covs { get; set; }

    public virtual DbSet<ZzRaw1Cpv> ZzRaw1Cpvs { get; set; }

    public virtual DbSet<ZzRaw1Pav> ZzRaw1Pavs { get; set; }

    public virtual DbSet<ZzRaw1Pbv> ZzRaw1Pbvs { get; set; }

    public virtual DbSet<ZzRaw1Pcv> ZzRaw1Pcvs { get; set; }

    public virtual DbSet<ZzRaw1Y> ZzRaw1ies { get; set; }

    public virtual DbSet<ZzRaw1Zv1> ZzRaw1Zv1s { get; set; }

    public virtual DbSet<ZzRaw1Zv2> ZzRaw1Zv2s { get; set; }

    public virtual DbSet<ZzRaw2Cav> ZzRaw2Cavs { get; set; }

    public virtual DbSet<ZzRaw2Cbv> ZzRaw2Cbvs { get; set; }

    public virtual DbSet<ZzRaw2Ccv> ZzRaw2Ccvs { get; set; }

    public virtual DbSet<ZzRaw2Cdv> ZzRaw2Cdvs { get; set; }

    public virtual DbSet<ZzRaw2Cev> ZzRaw2Cevs { get; set; }

    public virtual DbSet<ZzRaw2Cfv> ZzRaw2Cfvs { get; set; }

    public virtual DbSet<ZzRaw2Cgv> ZzRaw2Cgvs { get; set; }

    public virtual DbSet<ZzRaw2Chv> ZzRaw2Chvs { get; set; }

    public virtual DbSet<ZzRaw2Civ> ZzRaw2Civs { get; set; }

    public virtual DbSet<ZzRaw2Cjv> ZzRaw2Cjvs { get; set; }

    public virtual DbSet<ZzRaw2Ckv> ZzRaw2Ckvs { get; set; }

    public virtual DbSet<ZzRaw2Clv> ZzRaw2Clvs { get; set; }

    public virtual DbSet<ZzRaw2Cmv> ZzRaw2Cmvs { get; set; }

    public virtual DbSet<ZzRaw2Cnv> ZzRaw2Cnvs { get; set; }

    public virtual DbSet<ZzRaw2Cov> ZzRaw2Covs { get; set; }

    public virtual DbSet<ZzRaw2Cpv> ZzRaw2Cpvs { get; set; }

    public virtual DbSet<ZzRaw2Pav> ZzRaw2Pavs { get; set; }

    public virtual DbSet<ZzRaw2Pbv> ZzRaw2Pbvs { get; set; }

    public virtual DbSet<ZzRaw2Pcv> ZzRaw2Pcvs { get; set; }

    public virtual DbSet<ZzRaw2Y> ZzRaw2ies { get; set; }

    public virtual DbSet<ZzRaw2Zv1> ZzRaw2Zv1s { get; set; }

    public virtual DbSet<ZzRaw2Zv2> ZzRaw2Zv2s { get; set; }

    public virtual DbSet<ZzRaw3Cav> ZzRaw3Cavs { get; set; }

    public virtual DbSet<ZzRaw3Cbv> ZzRaw3Cbvs { get; set; }

    public virtual DbSet<ZzRaw3Ccv> ZzRaw3Ccvs { get; set; }

    public virtual DbSet<ZzRaw3Cdv> ZzRaw3Cdvs { get; set; }

    public virtual DbSet<ZzRaw3Cev> ZzRaw3Cevs { get; set; }

    public virtual DbSet<ZzRaw3Cfv> ZzRaw3Cfvs { get; set; }

    public virtual DbSet<ZzRaw3Cgv> ZzRaw3Cgvs { get; set; }

    public virtual DbSet<ZzRaw3Chv> ZzRaw3Chvs { get; set; }

    public virtual DbSet<ZzRaw3Civ> ZzRaw3Civs { get; set; }

    public virtual DbSet<ZzRaw3Cjv> ZzRaw3Cjvs { get; set; }

    public virtual DbSet<ZzRaw3Ckv> ZzRaw3Ckvs { get; set; }

    public virtual DbSet<ZzRaw3Clv> ZzRaw3Clvs { get; set; }

    public virtual DbSet<ZzRaw3Cmv> ZzRaw3Cmvs { get; set; }

    public virtual DbSet<ZzRaw3Cnv> ZzRaw3Cnvs { get; set; }

    public virtual DbSet<ZzRaw3Cov> ZzRaw3Covs { get; set; }

    public virtual DbSet<ZzRaw3Cpv> ZzRaw3Cpvs { get; set; }

    public virtual DbSet<ZzRaw3Pav> ZzRaw3Pavs { get; set; }

    public virtual DbSet<ZzRaw3Pbv> ZzRaw3Pbvs { get; set; }

    public virtual DbSet<ZzRaw3Pcv> ZzRaw3Pcvs { get; set; }

    public virtual DbSet<ZzRaw3Y> ZzRaw3ies { get; set; }

    public virtual DbSet<ZzRaw3Zv1> ZzRaw3Zv1s { get; set; }

    public virtual DbSet<ZzRaw3Zv2> ZzRaw3Zv2s { get; set; }

    public virtual DbSet<ZzRaw4Cav> ZzRaw4Cavs { get; set; }

    public virtual DbSet<ZzRaw4Cbv> ZzRaw4Cbvs { get; set; }

    public virtual DbSet<ZzRaw4Ccv> ZzRaw4Ccvs { get; set; }

    public virtual DbSet<ZzRaw4Cdv> ZzRaw4Cdvs { get; set; }

    public virtual DbSet<ZzRaw4Cev> ZzRaw4Cevs { get; set; }

    public virtual DbSet<ZzRaw4Cfv> ZzRaw4Cfvs { get; set; }

    public virtual DbSet<ZzRaw4Cgv> ZzRaw4Cgvs { get; set; }

    public virtual DbSet<ZzRaw4Chv> ZzRaw4Chvs { get; set; }

    public virtual DbSet<ZzRaw4Civ> ZzRaw4Civs { get; set; }

    public virtual DbSet<ZzRaw4Cjv> ZzRaw4Cjvs { get; set; }

    public virtual DbSet<ZzRaw4Ckv> ZzRaw4Ckvs { get; set; }

    public virtual DbSet<ZzRaw4Clv> ZzRaw4Clvs { get; set; }

    public virtual DbSet<ZzRaw4Cmv> ZzRaw4Cmvs { get; set; }

    public virtual DbSet<ZzRaw4Cnv> ZzRaw4Cnvs { get; set; }

    public virtual DbSet<ZzRaw4Cov> ZzRaw4Covs { get; set; }

    public virtual DbSet<ZzRaw4Cpv> ZzRaw4Cpvs { get; set; }

    public virtual DbSet<ZzRaw4Pav> ZzRaw4Pavs { get; set; }

    public virtual DbSet<ZzRaw4Pbv> ZzRaw4Pbvs { get; set; }

    public virtual DbSet<ZzRaw4Pcv> ZzRaw4Pcvs { get; set; }

    public virtual DbSet<ZzRaw4Y> ZzRaw4ies { get; set; }

    public virtual DbSet<ZzRaw4Zv1> ZzRaw4Zv1s { get; set; }

    public virtual DbSet<ZzRaw4Zv2> ZzRaw4Zv2s { get; set; }

    public virtual DbSet<ZzRaw5Cav> ZzRaw5Cavs { get; set; }

    public virtual DbSet<ZzRaw5Cbv> ZzRaw5Cbvs { get; set; }

    public virtual DbSet<ZzRaw5Ccv> ZzRaw5Ccvs { get; set; }

    public virtual DbSet<ZzRaw5Cdv> ZzRaw5Cdvs { get; set; }

    public virtual DbSet<ZzRaw5Cev> ZzRaw5Cevs { get; set; }

    public virtual DbSet<ZzRaw5Cfv> ZzRaw5Cfvs { get; set; }

    public virtual DbSet<ZzRaw5Cgv> ZzRaw5Cgvs { get; set; }

    public virtual DbSet<ZzRaw5Chv> ZzRaw5Chvs { get; set; }

    public virtual DbSet<ZzRaw5Civ> ZzRaw5Civs { get; set; }

    public virtual DbSet<ZzRaw5Cjv> ZzRaw5Cjvs { get; set; }

    public virtual DbSet<ZzRaw5Ckv> ZzRaw5Ckvs { get; set; }

    public virtual DbSet<ZzRaw5Clv> ZzRaw5Clvs { get; set; }

    public virtual DbSet<ZzRaw5Cmv> ZzRaw5Cmvs { get; set; }

    public virtual DbSet<ZzRaw5Cnv> ZzRaw5Cnvs { get; set; }

    public virtual DbSet<ZzRaw5Cov> ZzRaw5Covs { get; set; }

    public virtual DbSet<ZzRaw5Cpv> ZzRaw5Cpvs { get; set; }

    public virtual DbSet<ZzRaw5Pav> ZzRaw5Pavs { get; set; }

    public virtual DbSet<ZzRaw5Pbv> ZzRaw5Pbvs { get; set; }

    public virtual DbSet<ZzRaw5Pcv> ZzRaw5Pcvs { get; set; }

    public virtual DbSet<ZzRaw5Y> ZzRaw5ies { get; set; }

    public virtual DbSet<ZzRaw5Zv1> ZzRaw5Zv1s { get; set; }

    public virtual DbSet<ZzRaw5Zv2> ZzRaw5Zv2s { get; set; }

    public virtual DbSet<ZzRaw6Cav> ZzRaw6Cavs { get; set; }

    public virtual DbSet<ZzRaw6Cbv> ZzRaw6Cbvs { get; set; }

    public virtual DbSet<ZzRaw6Ccv> ZzRaw6Ccvs { get; set; }

    public virtual DbSet<ZzRaw6Cdv> ZzRaw6Cdvs { get; set; }

    public virtual DbSet<ZzRaw6Cev> ZzRaw6Cevs { get; set; }

    public virtual DbSet<ZzRaw6Cfv> ZzRaw6Cfvs { get; set; }

    public virtual DbSet<ZzRaw6Cgv> ZzRaw6Cgvs { get; set; }

    public virtual DbSet<ZzRaw6Chv> ZzRaw6Chvs { get; set; }

    public virtual DbSet<ZzRaw6Civ> ZzRaw6Civs { get; set; }

    public virtual DbSet<ZzRaw6Cjv> ZzRaw6Cjvs { get; set; }

    public virtual DbSet<ZzRaw6Ckv> ZzRaw6Ckvs { get; set; }

    public virtual DbSet<ZzRaw6Clv> ZzRaw6Clvs { get; set; }

    public virtual DbSet<ZzRaw6Cmv> ZzRaw6Cmvs { get; set; }

    public virtual DbSet<ZzRaw6Cnv> ZzRaw6Cnvs { get; set; }

    public virtual DbSet<ZzRaw6Cov> ZzRaw6Covs { get; set; }

    public virtual DbSet<ZzRaw6Cpv> ZzRaw6Cpvs { get; set; }

    public virtual DbSet<ZzRaw6Pav> ZzRaw6Pavs { get; set; }

    public virtual DbSet<ZzRaw6Pbv> ZzRaw6Pbvs { get; set; }

    public virtual DbSet<ZzRaw6Pcv> ZzRaw6Pcvs { get; set; }

    public virtual DbSet<ZzRaw6Y> ZzRaw6ies { get; set; }

    public virtual DbSet<ZzRaw6Zv1> ZzRaw6Zv1s { get; set; }

    public virtual DbSet<ZzRaw6Zv2> ZzRaw6Zv2s { get; set; }

    public virtual DbSet<ZzRaw7Cav> ZzRaw7Cavs { get; set; }

    public virtual DbSet<ZzRaw7Cbv> ZzRaw7Cbvs { get; set; }

    public virtual DbSet<ZzRaw7Ccv> ZzRaw7Ccvs { get; set; }

    public virtual DbSet<ZzRaw7Cdv> ZzRaw7Cdvs { get; set; }

    public virtual DbSet<ZzRaw7Cev> ZzRaw7Cevs { get; set; }

    public virtual DbSet<ZzRaw7Cfv> ZzRaw7Cfvs { get; set; }

    public virtual DbSet<ZzRaw7Cgv> ZzRaw7Cgvs { get; set; }

    public virtual DbSet<ZzRaw7Chv> ZzRaw7Chvs { get; set; }

    public virtual DbSet<ZzRaw7Civ> ZzRaw7Civs { get; set; }

    public virtual DbSet<ZzRaw7Cjv> ZzRaw7Cjvs { get; set; }

    public virtual DbSet<ZzRaw7Ckv> ZzRaw7Ckvs { get; set; }

    public virtual DbSet<ZzRaw7Clv> ZzRaw7Clvs { get; set; }

    public virtual DbSet<ZzRaw7Cmv> ZzRaw7Cmvs { get; set; }

    public virtual DbSet<ZzRaw7Cnv> ZzRaw7Cnvs { get; set; }

    public virtual DbSet<ZzRaw7Cov> ZzRaw7Covs { get; set; }

    public virtual DbSet<ZzRaw7Cpv> ZzRaw7Cpvs { get; set; }

    public virtual DbSet<ZzRaw7Pav> ZzRaw7Pavs { get; set; }

    public virtual DbSet<ZzRaw7Pbv> ZzRaw7Pbvs { get; set; }

    public virtual DbSet<ZzRaw7Pcv> ZzRaw7Pcvs { get; set; }

    public virtual DbSet<ZzRaw7Zv1> ZzRaw7Zv1s { get; set; }

    public virtual DbSet<ZzRaw7Zv2> ZzRaw7Zv2s { get; set; }

    public virtual DbSet<ZzRepCav> ZzRepCavs { get; set; }

    public virtual DbSet<ZzRepCbv> ZzRepCbvs { get; set; }

    public virtual DbSet<ZzRepCcv> ZzRepCcvs { get; set; }

    public virtual DbSet<ZzRepCdv> ZzRepCdvs { get; set; }

    public virtual DbSet<ZzRepCev> ZzRepCevs { get; set; }

    public virtual DbSet<ZzRepCfv> ZzRepCfvs { get; set; }

    public virtual DbSet<ZzRepCgv> ZzRepCgvs { get; set; }

    public virtual DbSet<ZzRepChv> ZzRepChvs { get; set; }

    public virtual DbSet<ZzRepCiv> ZzRepCivs { get; set; }

    public virtual DbSet<ZzRepCjv> ZzRepCjvs { get; set; }

    public virtual DbSet<ZzRepCkv> ZzRepCkvs { get; set; }

    public virtual DbSet<ZzRepClv> ZzRepClvs { get; set; }

    public virtual DbSet<ZzRepCmv> ZzRepCmvs { get; set; }

    public virtual DbSet<ZzRepCnv> ZzRepCnvs { get; set; }

    public virtual DbSet<ZzRepCov> ZzRepCovs { get; set; }

    public virtual DbSet<ZzRepCpv> ZzRepCpvs { get; set; }

    public virtual DbSet<ZzRepPav> ZzRepPavs { get; set; }

    public virtual DbSet<ZzRepPbv> ZzRepPbvs { get; set; }

    public virtual DbSet<ZzRepPcv> ZzRepPcvs { get; set; }

    public virtual DbSet<ZzRepRawCav> ZzRepRawCavs { get; set; }

    public virtual DbSet<ZzRepRawCbv> ZzRepRawCbvs { get; set; }

    public virtual DbSet<ZzRepRawCcv> ZzRepRawCcvs { get; set; }

    public virtual DbSet<ZzRepRawPav> ZzRepRawPavs { get; set; }

    public virtual DbSet<ZzRepRawPcv> ZzRepRawPcvs { get; set; }

    public virtual DbSet<ZzRepSemiCav> ZzRepSemiCavs { get; set; }

    public virtual DbSet<ZzRepSemiCbv> ZzRepSemiCbvs { get; set; }

    public virtual DbSet<ZzRepSemiCcv> ZzRepSemiCcvs { get; set; }

    public virtual DbSet<ZzRepSemiPav> ZzRepSemiPavs { get; set; }

    public virtual DbSet<ZzRepSemiPcv> ZzRepSemiPcvs { get; set; }

    public virtual DbSet<ZzRepY> ZzRepies { get; set; }

    public virtual DbSet<ZzRepZv1> ZzRepZv1s { get; set; }

    public virtual DbSet<ZzRepZv2> ZzRepZv2s { get; set; }

    public virtual DbSet<ZzSemi1Pav> ZzSemi1Pavs { get; set; }

    public virtual DbSet<ZzSemi2Pav> ZzSemi2Pavs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=103.91.204.106;port=3307;user=root;password=OudIaNolEGalEAT;database=02singsiam", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.5.41-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("account")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Acctype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("acctype");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Sumcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("sumcode");
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("blacklist")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardid");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("branch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(5)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("address");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Closeconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("closeconfig")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("config")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(3)")
                .HasColumnName("id");
            entity.Property(e => e.AddonMemo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("addon_memo");
            entity.Property(e => e.Arbranch)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("arbranch");
            entity.Property(e => e.Askamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("askamt");
            entity.Property(e => e.Askpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("askpc");
            entity.Property(e => e.Asktime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("asktime");
            entity.Property(e => e.Closeedit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("closeedit");
            entity.Property(e => e.Cutflat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cutflat");
            entity.Property(e => e.DataMore)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("data_more");
            entity.Property(e => e.Daylate)
                .HasDefaultValueSql("'7'")
                .HasColumnType("int(3)")
                .HasColumnName("daylate");
            entity.Property(e => e.Disablemanual)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("disablemanual");
            entity.Property(e => e.Editfee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("editfee");
            entity.Property(e => e.Externalar)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("externalar");
            entity.Property(e => e.Followamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("followamt");
            entity.Property(e => e.Followpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("followpc");
            entity.Property(e => e.Followtime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("followtime");
            entity.Property(e => e.Ftphost)
                .HasMaxLength(50)
                .HasColumnName("ftphost");
            entity.Property(e => e.Ftppass)
                .HasMaxLength(50)
                .HasColumnName("ftppass");
            entity.Property(e => e.Ftppath)
                .HasMaxLength(50)
                .HasColumnName("ftppath");
            entity.Property(e => e.Ftpuser)
                .HasMaxLength(50)
                .HasColumnName("ftpuser");
            entity.Property(e => e.Hurryamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("hurryamt");
            entity.Property(e => e.Hurrypc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("hurrypc");
            entity.Property(e => e.Hurrytime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("hurrytime");
            entity.Property(e => e.Latecap)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("latecap");
            entity.Property(e => e.Loancontrol)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loancontrol");
            entity.Property(e => e.Loancreate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loancreate");
            entity.Property(e => e.Loanservins)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loanservins");
            entity.Property(e => e.Localtaxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("localtaxrate");
            entity.Property(e => e.Maxins)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(1)")
                .HasColumnName("maxins");
            entity.Property(e => e.Orgaddress)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgaddress");
            entity.Property(e => e.Orgname)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgname");
            entity.Property(e => e.Orgtelfax)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgtelfax");
            entity.Property(e => e.Paymethod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("paymethod");
            entity.Property(e => e.Servicecharge)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("servicecharge");
            entity.Property(e => e.Signname)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("signname");
            entity.Property(e => e.Specialtaxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("specialtaxrate");
            entity.Property(e => e.Taxid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("taxid");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("taxrate");
            entity.Property(e => e.Wwwpath)
                .HasMaxLength(50)
                .HasColumnName("wwwpath");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("customer")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Cardid, "cardid").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-'")
                .HasColumnName("address");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Cardexpire)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardexpire");
            entity.Property(e => e.Cardexpireformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardexpireformat");
            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardid");
            entity.Property(e => e.HomeE)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("home_e");
            entity.Property(e => e.HomeN)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("home_n");
            entity.Property(e => e.Homemap)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("homemap");
            entity.Property(e => e.Jobdesc)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("jobdesc");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("nickname");
            entity.Property(e => e.Office)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office");
            entity.Property(e => e.OfficeE)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office_e");
            entity.Property(e => e.OfficeN)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office_n");
            entity.Property(e => e.Officeaddress)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officeaddress");
            entity.Property(e => e.Officemap)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officemap");
            entity.Property(e => e.Officetel)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officetel");
            entity.Property(e => e.Reference)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Expincome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("expincome")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Externalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("externalar")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "customer");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aramount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("aramount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("docno");
            entity.Property(e => e.Flg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("flg");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ExternalarDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("externalar_detail")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Cutamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("cutamount");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("docno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("insurance")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Lateconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lateconfig")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.FIntpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("f_intpc");
            entity.Property(e => e.LIntpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("l_intpc");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Logfile201301>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201301")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201701>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201701")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201712>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201712")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201801>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201801")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201802>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201802")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201803>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201803")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201804>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201804")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201805>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201805")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201806>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201806")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201807>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201807")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201808>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201808")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201809>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201809")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201810>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201810")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201811>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201811")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201812>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201812")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201901>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201901")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201902>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201902")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201903>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201903")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201904>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201904")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201905>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201905")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201906>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201906")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201907>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201907")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201908>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201908")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201909>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201909")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201910>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201910")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201911>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201911")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201912>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201912")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202001>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202001")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202002>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202002")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202003>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202003")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202004>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202004")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202005>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202005")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202006>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202006")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202007>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202007")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202008>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202008")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202009>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202009")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202010>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202010")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202011>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202011")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202012>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202012")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202101>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202101")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202102>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202102")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202103>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202103")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202104>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202104")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202105>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202105")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202106>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202106")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202107>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202107")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202108>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202108")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202109>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202109")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202110>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202110")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202111>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202111")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202112>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202112")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202201>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202201")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202202>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202202")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202203>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202203")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202204>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202204")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202205>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202205")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202206>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202206")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202207>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202207")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202208>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202208")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202209>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202209")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202210>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202210")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202211>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202211")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202212>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202212")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202301>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202301")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202302>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202302")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202303>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202303")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202304>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202304")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202305>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202305")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202306>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202306")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202307>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202307")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202308>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202308")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202309>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202309")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202310>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202310")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202311>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202311")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202312>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202312")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202401>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202401")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202402>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202402")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202403>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202403")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202404>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202404")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202405>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202405")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202406>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202406")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202407>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202407")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202408>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202408")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202409>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202409")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202410>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202410")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202411>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202411")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202412>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202412")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Periodtran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("periodtran")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("product")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cancelfee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cancelfee");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname9");
            entity.Property(e => e.Financemax)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("financemax");
            entity.Property(e => e.Financerate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("financerate");
            entity.Property(e => e.Loanmax)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("loanmax");
            entity.Property(e => e.Loanrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("loanrate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Promise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cancelno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("cancelno");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closedocno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closedocno");
            entity.Property(e => e.Closeresult)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closeresult");
            entity.Property(e => e.Coldata1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata1");
            entity.Property(e => e.Coldata2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata2");
            entity.Property(e => e.Coldata3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata3");
            entity.Property(e => e.Coldata4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata4");
            entity.Property(e => e.Coldata5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata5");
            entity.Property(e => e.Coldata6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata6");
            entity.Property(e => e.Coldata7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata7");
            entity.Property(e => e.Coldata8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata8");
            entity.Property(e => e.Coldata9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata9");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname9");
            entity.Property(e => e.Compromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("compromise");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Dateclose)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclose");
            entity.Property(e => e.Dateclosecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclosecal");
            entity.Property(e => e.Dateclosecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclosecalformat");
            entity.Property(e => e.Datecloseformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datecloseformat");
            entity.Property(e => e.Datewarn)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datewarn");
            entity.Property(e => e.Datewarnformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datewarnformat");
            entity.Property(e => e.Daypaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("daypaid");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Downamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("downamount");
            entity.Property(e => e.Firstdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("firstdate");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance1");
            entity.Property(e => e.Insurance1relation)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance1relation");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance2");
            entity.Property(e => e.Insurance2relation)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance2relation");
            entity.Property(e => e.Intrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("intrate");
            entity.Property(e => e.Latepc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("latepc");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("nampa");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Person1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person1");
            entity.Property(e => e.Person2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person2");
            entity.Property(e => e.Person3)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person3");
            entity.Property(e => e.Person4)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person4");
            entity.Property(e => e.Person5)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person5");
            entity.Property(e => e.Prddesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("prddesc");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Stockcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("stockcode");
            entity.Property(e => e.Sumcharge1)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("sumcharge1");
            entity.Property(e => e.Sumcharge2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("sumcharge2");
            entity.Property(e => e.Sumstatus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("sumstatus");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Totaldown)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("totaldown");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
            entity.Property(e => e.Warndesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("warndesc");
        });

        modelBuilder.Entity<PromiseMemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise_memo")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Descrip)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("descrip");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("remark");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<PromiseRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise_remark")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("remark");
            entity.Property(e => e.Tdatetime)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdatetimeformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatetimeformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Receiptdesc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("receiptdesc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceiptdescCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("receiptdesc_cancel")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Receipttran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("receipttran")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceipttranCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("receipttran_cancel")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Reinterest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("reinterest")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Artotal)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("artotal");
            entity.Property(e => e.Batchno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("batchno");
            entity.Property(e => e.Customer)
                .HasMaxLength(15)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer_name");
            entity.Property(e => e.Days)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("days");
            entity.Property(e => e.Latetotal)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("latetotal");
            entity.Property(e => e.Newcapital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newcapital");
            entity.Property(e => e.Newinterest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newinterest");
            entity.Property(e => e.Oldcapital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldcapital");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("station")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Accdocno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("accdocno");
            entity.Property(e => e.Addcapno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("addcapno");
            entity.Property(e => e.Arpaidno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arpaidno");
            entity.Property(e => e.Batchno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("batchno");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cloudcamera)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cloudcamera");
            entity.Property(e => e.Color1)
                .HasDefaultValueSql("'16777168'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color1");
            entity.Property(e => e.Color2)
                .HasDefaultValueSql("'4194304'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color2");
            entity.Property(e => e.Color3)
                .HasDefaultValueSql("'16777168'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color3");
            entity.Property(e => e.Color4)
                .HasDefaultValueSql("'4194304'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color4");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("ipaddress");
            entity.Property(e => e.Macaddress)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("macaddress");
            entity.Property(e => e.Promiseno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("promiseno");
            entity.Property(e => e.Receiptno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("receiptno");
            entity.Property(e => e.Specialtaxreceive)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxreceive");
            entity.Property(e => e.Stationno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("stationno");
            entity.Property(e => e.Taxreceive)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxreceive");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stock")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Data1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data1");
            entity.Property(e => e.Data2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data2");
            entity.Property(e => e.Data3)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data3");
            entity.Property(e => e.Data4)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data4");
            entity.Property(e => e.Data5)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data5");
            entity.Property(e => e.Data6)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data6");
            entity.Property(e => e.Data7)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data7");
            entity.Property(e => e.Data8)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data8");
            entity.Property(e => e.Data9)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data9");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("price");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Userfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userfile")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Adminflg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("adminflg");
            entity.Property(e => e.Branchchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("branchchg");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Menu1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu1");
            entity.Property(e => e.Menu2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu2");
            entity.Property(e => e.Menu3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu3");
            entity.Property(e => e.Menu4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu4");
            entity.Property(e => e.Menu5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu5");
            entity.Property(e => e.Menu6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu6");
            entity.Property(e => e.Menu7)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu7");
            entity.Property(e => e.Menu8)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu8");
            entity.Property(e => e.Menu9)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu9");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("password");
        });

        modelBuilder.Entity<Userreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userreport")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Allow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("allow");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Menucode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("menucode");
        });

        modelBuilder.Entity<ZzLogfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_logfile")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRaw1Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
        });

        modelBuilder.Entity<ZzRaw1Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
        });

        modelBuilder.Entity<ZzRaw1Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw1Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw1Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw1Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
        });

        modelBuilder.Entity<ZzRaw1Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw1Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw1Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.SrvPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
        });

        modelBuilder.Entity<ZzRaw1Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
        });

        modelBuilder.Entity<ZzRaw2Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw2Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw2Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw2Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw2Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw2Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw2Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw2Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRaw2Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
        });

        modelBuilder.Entity<ZzRaw2Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw3Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CloseCase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseDocNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseResult)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DateClose)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SumCharge1)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.SumCharge2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
        });

        modelBuilder.Entity<ZzRaw3Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period2).HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw4Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CloseCase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseDocNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseResult)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DateClose)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.SumCharge1)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.SumCharge2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
        });

        modelBuilder.Entity<ZzRaw4Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.PromiseNo, "PromiseNo");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
        });

        modelBuilder.Entity<ZzRaw5Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllInterest).HasColumnType("double(17,0)");
            entity.Property(e => e.AllService).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Insurance).HasColumnType("double(17,0)");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllInterest).HasColumnType("double(17,0)");
            entity.Property(e => e.AllService).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CloseCase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseDocNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CloseResult)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DateClose)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Insurance).HasColumnType("double(17,0)");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PrdDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SumCharge1)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.SumCharge2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Y>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ccv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Chv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Civ>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ckv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Clv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Zv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Zv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepCav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cdv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepCev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cev")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCfv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cfv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCgv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cgv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepChv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_chv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRepCiv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_civ")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCjv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cjv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRepCkv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ckv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepClv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_clv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRepCmv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cmv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCnv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cnv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepCov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cov")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AccNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DocNo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDesc");
        });

        modelBuilder.Entity<ZzRepCpv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cpv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepPav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepPbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepPcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepRawCav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_raw_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsName1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel1)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepRawCbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_raw_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsName1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel1)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepRawCcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_raw_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsName1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel1)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepRawPav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_raw_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsName1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel1)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepRawPcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_raw_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsName1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel1)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepSemiCav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_semi_cav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsName2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel2)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepSemiCbv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_semi_cbv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsName2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel2)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepSemiCcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_semi_ccv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsName2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel2)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepSemiPav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_semi_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsName2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel2)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepSemiPcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_semi_pcv")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsName2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsTel2)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromisePeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepY>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_y")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ZzRepZv1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_zv1")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRepZv2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_zv2")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzSemi1Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_semi1_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Overdueamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("overdueamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Periodbalance)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("periodbalance");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
        });

        modelBuilder.Entity<ZzSemi2Pav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_semi2_pav")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
