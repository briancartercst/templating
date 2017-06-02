﻿namespace Microsoft.AspNetCore.Authentication.Extensions
{
    public class AzureAdB2COptions
    {
        public string ClientId { get; set; }
        public string Instance { get; set; }
        public string Domain { get; set; }
        public string EditProfilePolicyId { get; set; }
        public string SignUpSignInPolicyId { get; set; }
        public string ResetPasswordPolicyId { get; set; }
        public string CallbackPath { get; set; }
    }
}