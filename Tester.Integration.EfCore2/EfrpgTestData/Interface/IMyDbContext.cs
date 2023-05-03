// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    public interface IMyDbContext : IDisposable
    {
        DbSet<A> A { get; set; } // A
        DbSet<Aaref> Aarefs { get; set; } // AAREF
        DbSet<AbOrderLinesAb> AbOrderLinesAbs { get; set; } // AB_OrderLinesAB_
        DbSet<AbOrdersAb> AbOrdersAbs { get; set; } // AB_OrdersAB_
        DbSet<Alpha_Harish3485> Alpha_Harish3485 { get; set; } // Harish3485
        DbSet<Alpha_Workflow> Alpha_Workflows { get; set; } // workflow
        DbSet<App_UserFacilityServiceRole> App_UserFacilityServiceRoles { get; set; } // UserFacilityServiceRole
        DbSet<AppUser> AppUsers { get; set; } // AppUser
        DbSet<Attendee> Attendees { get; set; } // Attendee
        DbSet<BatchTest> BatchTests { get; set; } // BatchTest
        DbSet<Beta_Harish3485> Beta_Harish3485 { get; set; } // Harish3485
        DbSet<Beta_ToAlpha> Beta_ToAlphas { get; set; } // ToAlpha
        DbSet<Beta_Workflow> Beta_Workflows { get; set; } // workflow
        DbSet<Bitfiddlerallcap> Bitfiddlerallcaps { get; set; } // BITFIDDLERALLCAPS
        DbSet<BitFiddlerCategoRy> BitFiddlerCategoRies { get; set; } // BitFiddlerCATEGORIES
        DbSet<BitFiddlerCurrenCy> BitFiddlerCurrenCies { get; set; } // BitFiddlerCURRENCIES
        DbSet<Blah> Blahs { get; set; } // Blah
        DbSet<BlahBlahLink> BlahBlahLinks { get; set; } // BlahBlahLink
        DbSet<BlahBlahLinkReadonly> BlahBlahLinkReadonlies { get; set; } // BlahBlahLink_readonly
        DbSet<BlahBlahLinkV2> BlahBlahLinkV2 { get; set; } // BlahBlahLink_v2
        DbSet<BlahBlargLink> BlahBlargLinks { get; set; } // BlahBlargLink
        DbSet<Blarg> Blargs { get; set; } // Blarg
        DbSet<Burak1> Burak1 { get; set; } // Burak1
        DbSet<Burak2> Burak2 { get; set; } // Burak2
        DbSet<CalculatedColumnNotNull> CalculatedColumnNotNulls { get; set; } // CalculatedColumnNotNull
        DbSet<Car> Cars { get; set; } // Car
        DbSet<CarToColour> CarToColours { get; set; } // CarToColour
        DbSet<ClientCreationState> ClientCreationStates { get; set; } // ClientCreationState
        DbSet<CmsFile> CmsFiles { get; set; } // CMS_File
        DbSet<CmsFileTag> CmsFileTags { get; set; } // CMS_FileTag
        DbSet<CmsTag> CmsTags { get; set; } // CMS_Tag
        DbSet<CodeMeetingTopicDetail> CodeMeetingTopicDetails { get; set; } // CODE_MeetingTopicDetails
        DbSet<CodeObject> CodeObjects { get; set; } // CodeObject
        DbSet<CodeParamMeetingTopicDetailSource> CodeParamMeetingTopicDetailSources { get; set; } // CODE_PARAM_MeetingTopicDetailSource
        DbSet<Colour> Colours { get; set; } // Colour
        DbSet<ColumnNameAndType> ColumnNameAndTypes { get; set; } // ColumnNameAndTypes
        DbSet<ComplexView> ComplexViews { get; set; } // ComplexView
        DbSet<Country> Countries { get; set; } // Country
        DbSet<DateTimeDefaultTest> DateTimeDefaultTests { get; set; } // DateTimeDefaultTest
        DbSet<dcg_RovColumnDefinition> dcg_RovColumnDefinitions { get; set; } // rov_ColumnDefinitions
        DbSet<DefaultCheckForNull> DefaultCheckForNulls { get; set; } // DefaultCheckForNull
        DbSet<DsOpe> DsOpes { get; set; } // DSOpe
        DbSet<EnumsWithStringAsValue> EnumsWithStringAsValues { get; set; } // EnumsWithStringAsValue
        DbSet<EnumTest_DaysOfWeek> EnumTest_DaysOfWeeks { get; set; } // DaysOfWeek
        DbSet<EnumTest_OpenDay> EnumTest_OpenDays { get; set; } // OpenDays
        DbSet<EnumWithDefaultValue> EnumWithDefaultValues { get; set; } // EnumWithDefaultValue
        DbSet<EventProcessor> EventProcessors { get; set; } // EventProcessor
        DbSet<EventProcessorEventFilter> EventProcessorEventFilters { get; set; } // EventProcessorEventFilter
        DbSet<FFRS_Cv> FFRS_Cvs { get; set; } // CV
        DbSet<FinancialInstitutionOffice> FinancialInstitutionOffices { get; set; } // FinancialInstitutionOffice
        DbSet<FkTest_SmallDecimalTestAttribute> FkTest_SmallDecimalTestAttributes { get; set; } // SmallDecimalTestAttribute
        DbSet<Footer> Footers { get; set; } // footer
        DbSet<ForeignKeyIsNotEnforced> ForeignKeyIsNotEnforceds { get; set; } // ForeignKeyIsNotEnforced
        DbSet<ForeignKeyIsNotEnforcedItem> ForeignKeyIsNotEnforcedItems { get; set; } // ForeignKeyIsNotEnforcedItem
        DbSet<HasPrincipalKeyTestChild> HasPrincipalKeyTestChilds { get; set; } // HasPrincipalKeyTestChild
        DbSet<HasPrincipalKeyTestParent> HasPrincipalKeyTestParents { get; set; } // HasPrincipalKeyTestParent
        DbSet<Header> Headers { get; set; } // header
        DbSet<HierarchyTest> HierarchyTests { get; set; } // hierarchy_test
        DbSet<Issue47_Role> Issue47_Roles { get; set; } // Role
        DbSet<Issue47_User> Issue47_Users { get; set; } // Users
        DbSet<Issue47_UserRole> Issue47_UserRoles { get; set; } // UserRoles
        DbSet<MultipleKey> MultipleKeys { get; set; } // MultipleKeys
        DbSet<OneEightSix_Issue> OneEightSix_Issues { get; set; } // Issue
        DbSet<OneEightSix_IssueUploadedFile> OneEightSix_IssueUploadedFiles { get; set; } // IssueUploadedFile
        DbSet<OneEightSix_UploadedFile> OneEightSix_UploadedFiles { get; set; } // UploadedFile
        DbSet<PeriodTestTable> PeriodTestTables { get; set; } // PeriodTestTable
        DbSet<Person> People { get; set; } // Person
        DbSet<PersonPost> PersonPosts { get; set; } // PersonPosts
        DbSet<PkOrdinalTest> PkOrdinalTests { get; set; } // pk_ordinal_test
        DbSet<PropertyTypesToAdd> PropertyTypesToAdds { get; set; } // PropertyTypesToAdd
        DbSet<SequenceTest> SequenceTests { get; set; } // SequenceTest
        DbSet<SequenceTestPartTwo> SequenceTestPartTwoes { get; set; } // SequenceTestPartTwo
        DbSet<SmallDecimalTest> SmallDecimalTests { get; set; } // SmallDecimalTest
        DbSet<SmallDecimalTestView> SmallDecimalTestViews { get; set; } // SmallDecimalTestView
        DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns
        DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo
        DbSet<Synonyms_Child> Synonyms_Children { get; set; } // Child
        DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent
        DbSet<TableA> TableAs { get; set; } // TableA
        DbSet<TableB> TableBs { get; set; } // TableB
        DbSet<TableMappingWithSpace> TableMappingWithSpaces { get; set; } // table mapping with space
        DbSet<TableWithDuplicateColumnName> TableWithDuplicateColumnNames { get; set; } // table with duplicate column names
        DbSet<TableWithSpace> TableWithSpaces { get; set; } // table with space
        DbSet<TableWithSpaceAndInColumn> TableWithSpaceAndInColumns { get; set; } // table with space and in columns
        DbSet<TableWithSpaceInColumnOnly> TableWithSpaceInColumnOnlies { get; set; } // TableWithSpaceInColumnOnly
        DbSet<TadeuszSobol> TadeuszSobols { get; set; } // TadeuszSobol
        DbSet<Task1> Task1 { get; set; } // Task
        DbSet<TblOrder> TblOrders { get; set; } // tblOrders
        DbSet<TblOrderError> TblOrderErrors { get; set; } // tblOrderErrors
        DbSet<TblOrderErrorsAb> TblOrderErrorsAbs { get; set; } // tblOrderErrorsAB_
        DbSet<TblOrderLine> TblOrderLines { get; set; } // tblOrderLines
        DbSet<TemporalDepartment> TemporalDepartments { get; set; } // TemporalDepartment
        DbSet<TemporalDepartmentHistory> TemporalDepartmentHistories { get; set; } // TemporalDepartmentHistory
        DbSet<ThisIsMemoryOptimised> ThisIsMemoryOptimiseds { get; set; } // ThisIsMemoryOptimised
        DbSet<Ticket> Tickets { get; set; } // Ticket
        DbSet<TimestampNotNull> TimestampNotNulls { get; set; } // TimestampNotNull
        DbSet<TimestampNullable> TimestampNullables { get; set; } // TimestampNullable
        DbSet<Token> Tokens { get; set; } // Token
        DbSet<User> Users { get; set; } // User
        DbSet<User309> User309 { get; set; } // User309
        DbSet<UserDocument> UserDocuments { get; set; } // User_Document
        DbSet<Versioned> Versioneds { get; set; } // Versioned
        DbSet<VersionedNullable> VersionedNullables { get; set; } // VersionedNullable
        DbSet<ViewWithSpace> ViewWithSpaces { get; set; } // view with space
        DbSet<WVN_Article> WVN_Articles { get; set; } // Articles
        DbSet<Брендытовара> Брендытовара { get; set; } // Бренды товара

        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        DatabaseFacade Database { get; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        EntityEntry Add(object entity);
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        Task AddRangeAsync(params object[] entities);
        Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class;
        Task<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default);
        void AddRange(IEnumerable<object> entities);
        void AddRange(params object[] entities);

        EntityEntry Attach(object entity);
        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;
        void AttachRange(IEnumerable<object> entities);
        void AttachRange(params object[] entities);

        EntityEntry Entry(object entity);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;
        Task<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;
        Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;
        Task<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken);
        Task<object> FindAsync(Type entityType, params object[] keyValues);
        object Find(Type entityType, params object[] keyValues);

        EntityEntry Remove(object entity);
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        void RemoveRange(IEnumerable<object> entities);
        void RemoveRange(params object[] entities);

        EntityEntry Update(object entity);
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        void UpdateRange(IEnumerable<object> entities);
        void UpdateRange(params object[] entities);


        // Stored Procedures
        int AddTwoValues(int? a, int? b);
        // AddTwoValuesAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int AddTwoValuesWithResult(int? a, int? b, out int? result, out int? result2);
        // AddTwoValuesWithResultAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int Alpha_Overclock(DateTime? parameter);
        // Alpha_OverclockAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int App_UspCmtUserFsrUpdate(int? userId, int? fsrId, out int? ufsrId);
        // App_UspCmtUserFsrUpdateAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int ASimpleExample();
        // ASimpleExampleAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int Beta_Overclock(DateTime? parameter);
        // Beta_OverclockAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        // C182Test2ReturnModel C182Test2(int? flag); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // Task<C182Test2ReturnModel> C182Test2Async(int? flag); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.

        // CheckIfApplicationIsCompleteReturnModel CheckIfApplicationIsComplete(int? applicationId, out bool? isApplicationComplete); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // CheckIfApplicationIsCompleteAsync() cannot be created due to having out parameters, or is relying on the procedure result (CheckIfApplicationIsCompleteReturnModel)

        List<ColourPivotReturnModel> ColourPivot();
        List<ColourPivotReturnModel> ColourPivot(out int procResult);
        Task<List<ColourPivotReturnModel>> ColourPivotAsync();

        List<ColumnNameAndTypesProcReturnModel> ColumnNameAndTypesProc();
        List<ColumnNameAndTypesProcReturnModel> ColumnNameAndTypesProc(out int procResult);
        Task<List<ColumnNameAndTypesProcReturnModel>> ColumnNameAndTypesProcAsync();

        int ConvertToString(int? someValue, out string someString);
        // ConvertToStringAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        List<DboProcDataFromFfrsReturnModel> DboProcDataFromFfrs(int? maxId);
        List<DboProcDataFromFfrsReturnModel> DboProcDataFromFfrs(int? maxId, out int procResult);
        Task<List<DboProcDataFromFfrsReturnModel>> DboProcDataFromFfrsAsync(int? maxId);

        List<DboProcDataFromFfrsAndDboReturnModel> DboProcDataFromFfrsAndDbo();
        List<DboProcDataFromFfrsAndDboReturnModel> DboProcDataFromFfrsAndDbo(out int procResult);
        Task<List<DboProcDataFromFfrsAndDboReturnModel>> DboProcDataFromFfrsAndDboAsync();

        List<DsOpeProcReturnModel> DsOpeProc();
        List<DsOpeProcReturnModel> DsOpeProc(out int procResult);
        Task<List<DsOpeProcReturnModel>> DsOpeProcAsync();

        List<FFRS_CvDataReturnModel> FFRS_CvData(int? maxId);
        List<FFRS_CvDataReturnModel> FFRS_CvData(int? maxId, out int procResult);
        Task<List<FFRS_CvDataReturnModel>> FFRS_CvDataAsync(int? maxId);

        List<FFRS_DataFromDboReturnModel> FFRS_DataFromDbo();
        List<FFRS_DataFromDboReturnModel> FFRS_DataFromDbo(out int procResult);
        Task<List<FFRS_DataFromDboReturnModel>> FFRS_DataFromDboAsync();

        List<FFRS_DataFromDboAndFfrsReturnModel> FFRS_DataFromDboAndFfrs();
        List<FFRS_DataFromDboAndFfrsReturnModel> FFRS_DataFromDboAndFfrs(out int procResult);
        Task<List<FFRS_DataFromDboAndFfrsReturnModel>> FFRS_DataFromDboAndFfrsAsync();

        List<FkTest_HelloReturnModel> FkTest_Hello();
        List<FkTest_HelloReturnModel> FkTest_Hello(out int procResult);
        Task<List<FkTest_HelloReturnModel>> FkTest_HelloAsync();

        List<GetSmallDecimalTestReturnModel> GetSmallDecimalTest(int? maxId);
        List<GetSmallDecimalTestReturnModel> GetSmallDecimalTest(int? maxId, out int procResult);
        Task<List<GetSmallDecimalTestReturnModel>> GetSmallDecimalTestAsync(int? maxId);

        int InsertRecord(string data, out int? insertedId);
        // InsertRecordAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int InsertRecordThree(string data, out int? insertedId, int? someId, out int? anotherInsertedId);
        // InsertRecordThreeAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int InsertRecordTwo(string data, out int? insertedId, out int? anotherInsertedId);
        // InsertRecordTwoAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int MinTripSequenceStart(out DateTime? minTripSequenceStartParam);
        // MinTripSequenceStartAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int MinTripSequenceStartNull(out DateTime? minTripSequenceStartParam);
        // MinTripSequenceStartNullAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int NvarcharTest(string maxOutputParam, string normalOutputParam);
        // NvarcharTestAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int Omega_Overclock(DateTime? parameter);
        // Omega_OverclockAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int ProcTestDecimalOutput(out decimal? perfectNumber);
        // ProcTestDecimalOutputAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int ProcTestDecimalOutputV2(out decimal? perfectNumber);
        // ProcTestDecimalOutputV2Async() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int ProcTestDecimalOutputV3Default(out decimal? perfectNumber);
        // ProcTestDecimalOutputV3DefaultAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        List<SpatialTypesNoParamsReturnModel> SpatialTypesNoParams();
        List<SpatialTypesNoParamsReturnModel> SpatialTypesNoParams(out int procResult);
        Task<List<SpatialTypesNoParamsReturnModel>> SpatialTypesNoParamsAsync();

        List<SpatialTypesWithParamsReturnModel> SpatialTypesWithParams(NetTopologySuite.Geometries.Geometry geometry, NetTopologySuite.Geometries.Point geography);
        List<SpatialTypesWithParamsReturnModel> SpatialTypesWithParams(NetTopologySuite.Geometries.Geometry geometry, NetTopologySuite.Geometries.Point geography, out int procResult);
        Task<List<SpatialTypesWithParamsReturnModel>> SpatialTypesWithParamsAsync(NetTopologySuite.Geometries.Geometry geometry, NetTopologySuite.Geometries.Point geography);

        // StpMultipleIdenticalResultsReturnModel StpMultipleIdenticalResults(int? someVar); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // Task<StpMultipleIdenticalResultsReturnModel> StpMultipleIdenticalResultsAsync(int? someVar); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.

        // StpMultipleMultipleResultsWithParamsReturnModel StpMultipleMultipleResultsWithParams(int? firstVal, int? secondVal, int? thirdVal); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // Task<StpMultipleMultipleResultsWithParamsReturnModel> StpMultipleMultipleResultsWithParamsAsync(int? firstVal, int? secondVal, int? thirdVal); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.

        // StpMultipleResultsReturnModel StpMultipleResults(); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // Task<StpMultipleResultsReturnModel> StpMultipleResultsAsync(); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.

        // StpMultipleResultsWithParamsReturnModel StpMultipleResultsWithParams(int? firstVal, int? secondVal); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.
        // Task<StpMultipleResultsWithParamsReturnModel> StpMultipleResultsWithParamsAsync(int? firstVal, int? secondVal); Cannot be created as EF Core does not yet support stored procedures with multiple result sets.

        List<StpNoParamsTestReturnModel> StpNoParamsTest();
        List<StpNoParamsTestReturnModel> StpNoParamsTest(out int procResult);
        Task<List<StpNoParamsTestReturnModel>> StpNoParamsTestAsync();

        int StpNoReturnFields();
        // StpNoReturnFieldsAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        List<StpNullableParamsTestReturnModel> StpNullableParamsTest(int? aVal, int? bVal);
        List<StpNullableParamsTestReturnModel> StpNullableParamsTest(int? aVal, int? bVal, out int procResult);
        Task<List<StpNullableParamsTestReturnModel>> StpNullableParamsTestAsync(int? aVal, int? bVal);

        List<StpTestReturnModel> StpTest(string strDateFrom, string strDateTo, out bool? retBool);
        List<StpTestReturnModel> StpTest(string strDateFrom, string strDateTo, out bool? retBool, out int procResult);
        // StpTestAsync() cannot be created due to having out parameters, or is relying on the procedure result (List<StpTestReturnModel>)

        List<StpTestUnderscoreTestReturnModel> StpTestUnderscoreTest(string strDateFrom, string strDateTo);
        List<StpTestUnderscoreTestReturnModel> StpTestUnderscoreTest(string strDateFrom, string strDateTo, out int procResult);
        Task<List<StpTestUnderscoreTestReturnModel>> StpTestUnderscoreTestAsync(string strDateFrom, string strDateTo);

        int StupidStoredProcedureParams(string reqType, short? dept, short? @class, short? item);
        // StupidStoredProcedureParamsAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int StupidStoredProcedureParams2(string @override, short? @readonly, short? @class, short? @enum);
        // StupidStoredProcedureParams2Async() cannot be created due to having out parameters, or is relying on the procedure result (int)

        List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt);
        List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt, out int procResult);
        Task<List<Synonyms_SimpleStoredProcReturnModel>> Synonyms_SimpleStoredProcAsync(int? inputInt);

        List<TestReturnStringReturnModel> TestReturnString();
        List<TestReturnStringReturnModel> TestReturnString(out int procResult);
        Task<List<TestReturnStringReturnModel>> TestReturnStringAsync();

        int ThisHasMixedOutParameters(DateTime? foo, out int? firstOutParam, DateTime? bar, out int? secondOutParam, DateTime? baz);
        // ThisHasMixedOutParametersAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UserDefinedTypeSampleStoredProc(int? a, DataTable type, int? b);
        // UserDefinedTypeSampleStoredProcAsync() cannot be created due to having out parameters, or is relying on the procedure result (int)

        List<XmlDataV1ReturnModel> XmlDataV1();
        List<XmlDataV1ReturnModel> XmlDataV1(out int procResult);
        Task<List<XmlDataV1ReturnModel>> XmlDataV1Async();

        int XmlDataV2();
        // XmlDataV2Async() cannot be created due to having out parameters, or is relying on the procedure result (int)

    }
}
// </auto-generated>
