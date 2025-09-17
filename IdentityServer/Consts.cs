namespace IdentityServer;

public static class Consts
{

    // AGOV
    // Minimal AGOVaq level
    // Can have one of the following values:
    // 100 - self declaration only: the application allows all levels of identity verifications including self declared accounts.
    // 200 - address checked: the application requires that an APost letter was successfully sent at the address of the subject.
    // 300 - strong identity check: the application requires that a third party has verified an official passport or identity card.
    // 400 - strong identity + OASI number: same as 300 plus a verified OASI (aka AHV, SVNR) number

    public static readonly string AGOV_TC_AC_100 = "urn:qa.agov.ch:names:tc:ac:classes:100";
    public static readonly string AGOV_TC_AC_200 = "urn:qa.agov.ch:names:tc:ac:classes:200";
    public static readonly string AGOV_TC_AC_300 = "urn:qa.agov.ch:names:tc:ac:classes:300";
    public static readonly string AGOV_TC_AC_400 = "urn:qa.agov.ch:names:tc:ac:classes:400";
    public static readonly string AGOV_TC_AC_500 = "urn:qa.agov.ch:names:tc:ac:classes:500";
    public static readonly string AGOV_TC_AC_600 = "urn:qa.agov.ch:names:tc:ac:classes:600";
}
