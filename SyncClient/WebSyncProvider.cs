using Dotmim.Sync;
using Dotmim.Sync.Builders;
using Dotmim.Sync.Enumerations;
using Dotmim.Sync.Manager;
using System;
using System.Data.Common;

internal class WebSyncProvider : CoreProvider
{
    private Uri uri;

    public WebSyncProvider(Uri uri)
    {
        this.uri = uri;
    }

    public override string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool CanBeServerProvider => throw new NotImplementedException();

    public override ConstraintsLevelAction ConstraintsLevelAction => throw new NotImplementedException();

    public override DbConnection CreateConnection()
    {
        throw new NotImplementedException();
    }

    public override DbDatabaseBuilder GetDatabaseBuilder()
    {
        throw new NotImplementedException();
    }

    public override string GetDatabaseName()
    {
        throw new NotImplementedException();
    }

    public override DbMetadata GetMetadata()
    {
        throw new NotImplementedException();
    }

    public override string GetProviderTypeName()
    {
        throw new NotImplementedException();
    }

    public override DbScopeBuilder GetScopeBuilder(string scopeInfoTableName)
    {
        throw new NotImplementedException();
    }

    public override string GetShortProviderTypeName()
    {
        throw new NotImplementedException();
    }

    public override DbSyncAdapter GetSyncAdapter(SyncTable tableDescription, ScopeInfo scopeInfo)
    {
        throw new NotImplementedException();
    }
}