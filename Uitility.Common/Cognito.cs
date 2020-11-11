﻿using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uitility
{
    public static class Cognito
    {
        private static string _clientId = "6h7e1s1m2njn1geiqgg0520mpk";
        private static string UserPoolId = "ap-southeast-1_4H2wwCXxU";
        //
        private static string UserPoolId_S4M = "ap-southeast-1_vKbNt46E8";
        private static string _clientIdS4M = "6ha1psvpgbmq0p2q7e42pkp9rj";
        //
        private static string UserPoolId_Daihu = "ap-southeast-1_3INv8Gobd";
        private static string _clientIdDaihu = "3vqo4o9t8mrhpr03h5uhljs9r7";
        //
        private static readonly RegionEndpoint _region = RegionEndpoint.APSoutheast1;
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static async Task<AuthenticationResultType> GetTokenDaihu(string userName = "daint", string password = "Davidkmhd!1")
        {
            try
            {
                var cognito = new AmazonCognitoIdentityProviderClient(_region);

                var request = new AdminInitiateAuthRequest
                {
                    UserPoolId = UserPoolId_Daihu,
                    ClientId = _clientIdDaihu,

                    AuthFlow = AuthFlowType.ADMIN_USER_PASSWORD_AUTH
                };
                request.AuthParameters.Add("USERNAME", userName);
                request.AuthParameters.Add("PASSWORD", password);

                var response = await cognito.AdminInitiateAuthAsync(request);



                var accesstoken = new JwtSecurityToken(response.AuthenticationResult.AccessToken);
                var idtoken = new JwtSecurityToken(response.AuthenticationResult.IdToken);

                var now = DateTime.UtcNow;
                var expire = accesstoken.ValidTo;
                var value = expire - now;

                return response.AuthenticationResult;


            }
            catch (InvalidParameterException ex)
            {
                throw;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
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
        public static async Task<AuthenticationResultType> GetTokenS4M(string userName = "daint", string password = "Davidkmhd!1")
        {
            try
            {
                var cognito = new AmazonCognitoIdentityProviderClient(_region);
                var request = new AdminInitiateAuthRequest
                {
                    UserPoolId = UserPoolId_S4M,
                    ClientId = _clientIdS4M,
                    AuthFlow = AuthFlowType.ADMIN_USER_PASSWORD_AUTH
                };
                request.AuthParameters.Add("USERNAME", userName);
                request.AuthParameters.Add("PASSWORD", password);

                var response = await cognito.AdminInitiateAuthAsync(request);
                return response.AuthenticationResult;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public static async Task<AuthenticationResultType> RefreshToken(string refreshToken)
        {
            try
            {
                var cognito = new AmazonCognitoIdentityProviderClient(_region);
                var request = new AdminInitiateAuthRequest
                {
                    UserPoolId = UserPoolId_Daihu,
                    ClientId = _clientIdDaihu,
                    AuthFlow = AuthFlowType.REFRESH_TOKEN_AUTH
                };
                request.AuthParameters.Add("REFRESH_TOKEN", refreshToken);
                var result = await cognito.AdminInitiateAuthAsync(request);
                return result.AuthenticationResult;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
