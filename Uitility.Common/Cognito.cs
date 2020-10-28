using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Uitility
{
    public static class Cognito
    {
        private static string _clientId = "6h7e1s1m2njn1geiqgg0520mpk";
        private static string UserPoolId = "ap-southeast-1_4H2wwCXxU";
        private static readonly RegionEndpoint _region = RegionEndpoint.APSoutheast1;

        public static async Task<AuthenticationResultType> GetToken(string userName = "daint", string password = "Davidkmhd!1")
        {
            var cognito = new AmazonCognitoIdentityProviderClient(_region);
            var request = new AdminInitiateAuthRequest
            {
                UserPoolId = UserPoolId,
                ClientId = _clientId,
                AuthFlow = AuthFlowType.ADMIN_USER_PASSWORD_AUTH
            };
            request.AuthParameters.Add("USERNAME", userName);
            request.AuthParameters.Add("PASSWORD", password);

            var response = await cognito.AdminInitiateAuthAsync(request);
            return response.AuthenticationResult;
        }
    }
}
