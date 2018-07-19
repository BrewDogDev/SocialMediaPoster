namespace SocialMediaPoster
{
    
    /// <summary>
    /// Holds global constants, edit to change users for different sites
    /// </summary>
    class Config
    {
        //////////////////////////////////////////////////////////Medium//////////////////////////////////////////////////////////
        /// <summary>
        /// User ID of a medium user, 
        /// obtained by sending post request to https://api.medium.com/v1/me, 
        /// with an auth code(OAuth2.0)
        /// </summary>
        public const string MEDIUM_USER_ID= "19a2c10fb1a720552724c7660efea302754fb226d6e710ba27c39e9abfadd6c10";
        /// <summary>
        /// OAuth2.0 auth code for a medium user,
        /// obtained through logging into medium's website,
        /// >settings>Integration tokens
        /// </summary>
        public const string MEDIUM_USER_AUTH_TOKEN = "29dbab20d2aedaf422b03cdd9d6ac1793c4f8289759fb9bdb5c811f888a62e8cb";
        /// <summary>
        /// how to post will be published on Medium valid entries: public, draft, unlisted
        /// </summary>
        public const string MEDIUM_PUBLISH_STATUS = "public";

        //////////////////////////////////////////////////////////Twitter//////////////////////////////////////////////////////////
        public const string TWITTER_CONSUMER_KEY = "q6rRzunVWsmPdTlxB2zKgw2Ke";
        public const string TWITTER_CONSUMER_SECRET = "cCMHFJ9xvWFrGrKYiJibkjjVbwgfCpB8PU0u22vafTDoijOuO3";
        public const string TWITTER_ACCESS_TOKEN = "2655346412-CW99hvyJr5RJ9TjFYenfLZ4zq1NIBjptWNz0tl6";
        public const string TWITTER_TOKEN_SECRET = "L76Buslt4ktatLdZnKgcoL9Qk8fonQsoXFw66vs3MFrHF";

    }
}
