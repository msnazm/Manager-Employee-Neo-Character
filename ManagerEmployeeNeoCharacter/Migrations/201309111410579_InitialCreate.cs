namespace ManagerEmployeeNeoCharacter.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 100),
                        FirstMidName = c.String(nullable: false, maxLength: 50),
                        EnetrDate = c.String(nullable: false),
                        NameFather = c.String(nullable: false),
                        BirthDate = c.String(),
                        BirthCertificateNumber = c.String(nullable: false),
                        NationalCode = c.String(nullable: false),
                        HomeTell = c.String(nullable: false),
                        MobileTell = c.String(nullable: false),
                        HomeAddress = c.String(nullable: false),
                        OfficeAddress = c.String(nullable: false),
                        TheCompanyJobs = c.String(nullable: false),
                        Province = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Neo",
                c => new
                    {
                        NeoID = c.Int(nullable: false, identity: true),
                        NA = c.Int(nullable: false),
                        NB = c.Int(nullable: false),
                        NC = c.Int(nullable: false),
                        ND = c.Int(nullable: false),
                        NE = c.Int(nullable: false),
                        NF = c.Int(nullable: false),
                        NG = c.Int(nullable: false),
                        NH = c.Int(nullable: false),
                        NI = c.Int(nullable: false),
                        NJ = c.Int(nullable: false),
                        NK = c.Int(nullable: false),
                        NN = c.Int(nullable: false),
                        N = c.Int(nullable: false),
                        EA = c.Int(nullable: false),
                        EB = c.Int(nullable: false),
                        EC = c.Int(nullable: false),
                        ED = c.Int(nullable: false),
                        EE = c.Int(nullable: false),
                        EF = c.Int(nullable: false),
                        EG = c.Int(nullable: false),
                        EH = c.Int(nullable: false),
                        EI = c.Int(nullable: false),
                        EJ = c.Int(nullable: false),
                        EK = c.Int(nullable: false),
                        EN = c.Int(nullable: false),
                        E = c.Int(nullable: false),
                        OA = c.Int(nullable: false),
                        OB = c.Int(nullable: false),
                        OC = c.Int(nullable: false),
                        OD = c.Int(nullable: false),
                        OE = c.Int(nullable: false),
                        OF = c.Int(nullable: false),
                        OG = c.Int(nullable: false),
                        OH = c.Int(nullable: false),
                        OI = c.Int(nullable: false),
                        OJ = c.Int(nullable: false),
                        OK = c.Int(nullable: false),
                        ON = c.Int(nullable: false),
                        O = c.Int(nullable: false),
                        AA = c.Int(nullable: false),
                        AB = c.Int(nullable: false),
                        AC = c.Int(nullable: false),
                        AD = c.Int(nullable: false),
                        AE = c.Int(nullable: false),
                        AF = c.Int(nullable: false),
                        AG = c.Int(nullable: false),
                        AH = c.Int(nullable: false),
                        AI = c.Int(nullable: false),
                        AJ = c.Int(nullable: false),
                        AK = c.Int(nullable: false),
                        AN = c.Int(nullable: false),
                        A = c.Int(nullable: false),
                        CA = c.Int(nullable: false),
                        CB = c.Int(nullable: false),
                        CC = c.Int(nullable: false),
                        CD = c.Int(nullable: false),
                        CE = c.Int(nullable: false),
                        CF = c.Int(nullable: false),
                        CG = c.Int(nullable: false),
                        CH = c.Int(nullable: false),
                        CI = c.Int(nullable: false),
                        CJ = c.Int(nullable: false),
                        CK = c.Int(nullable: false),
                        CN = c.Int(nullable: false),
                        C = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NeoID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        CharacterID = c.Int(nullable: false, identity: true),
                        AA = c.Int(nullable: false),
                        AB = c.Int(nullable: false),
                        AC = c.Int(nullable: false),
                        AD = c.Int(nullable: false),
                        AE = c.Int(nullable: false),
                        AF = c.Int(nullable: false),
                        AG = c.Int(nullable: false),
                        AH = c.Int(nullable: false),
                        A = c.Int(nullable: false),
                        BA = c.Int(nullable: false),
                        BB = c.Int(nullable: false),
                        BC = c.Int(nullable: false),
                        BD = c.Int(nullable: false),
                        BE = c.Int(nullable: false),
                        BF = c.Int(nullable: false),
                        BG = c.Int(nullable: false),
                        BH = c.Int(nullable: false),
                        B = c.Int(nullable: false),
                        GA = c.Int(nullable: false),
                        GB = c.Int(nullable: false),
                        GC = c.Int(nullable: false),
                        GD = c.Int(nullable: false),
                        GE = c.Int(nullable: false),
                        GF = c.Int(nullable: false),
                        GG = c.Int(nullable: false),
                        GH = c.Int(nullable: false),
                        G = c.Int(nullable: false),
                        DA = c.Int(nullable: false),
                        DB = c.Int(nullable: false),
                        DC = c.Int(nullable: false),
                        DD = c.Int(nullable: false),
                        DE = c.Int(nullable: false),
                        DF = c.Int(nullable: false),
                        DG = c.Int(nullable: false),
                        DH = c.Int(nullable: false),
                        D = c.Int(nullable: false),
                        HA = c.Int(nullable: false),
                        HB = c.Int(nullable: false),
                        HC = c.Int(nullable: false),
                        HD = c.Int(nullable: false),
                        HE = c.Int(nullable: false),
                        HF = c.Int(nullable: false),
                        HG = c.Int(nullable: false),
                        HH = c.Int(nullable: false),
                        H = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Statuss",
                c => new
                    {
                        StatussID = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        NumberSend = c.Int(nullable: false),
                        Attach = c.String(),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatussID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Statuss", new[] { "EmployeeID" });
            DropIndex("dbo.Character", new[] { "EmployeeID" });
            DropIndex("dbo.Neo", new[] { "EmployeeID" });
            DropForeignKey("dbo.Statuss", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Character", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Neo", "EmployeeID", "dbo.Employee");
            DropTable("dbo.Statuss");
            DropTable("dbo.Character");
            DropTable("dbo.Neo");
            DropTable("dbo.Employee");
        }
    }
}
