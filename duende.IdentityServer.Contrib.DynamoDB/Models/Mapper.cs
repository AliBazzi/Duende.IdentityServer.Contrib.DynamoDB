using System;
using Amazon.Util;

namespace Duende.IdentityServer.Contrib.DynamoDB.Models
{
    public static class Mapper
    {
        public static PersistedGrant ToPersistedGrantModel(Duende.IdentityServer.Models.PersistedGrant grant)
        {
            return new PersistedGrant
            {
                Key = grant.Key,
                ClientId = grant.ClientId,
                SessionId = grant.SessionId,
                SubjectId = grant.SubjectId,
                Data = grant.Data,
                Type = grant.Type,
                Description = grant.Description,
                Expiration = grant.Expiration.HasValue ? new Nullable<int>(AWSSDKUtils.ConvertToUnixEpochSeconds(grant.Expiration.Value)) : null,
                CreationTime = grant.CreationTime,
                ConsumedTime = grant.ConsumedTime
            };
        }

        public static Duende.IdentityServer.Models.PersistedGrant ToPersistedGrant(PersistedGrant grant)
        {
            return new Duende.IdentityServer.Models.PersistedGrant
            {
                Key = grant.Key,
                ClientId = grant.ClientId,
                SessionId = grant.SessionId,
                SubjectId = grant.SubjectId,
                Data = grant.Data,
                Type = grant.Type,
                Description = grant.Description,
                Expiration = grant.Expiration.HasValue ? new DateTime?(AWSSDKUtils.ConvertFromUnixEpochSeconds(grant.Expiration.Value)) : null,
                CreationTime = grant.CreationTime,
                ConsumedTime = grant.ConsumedTime
            };
        }
    }
}