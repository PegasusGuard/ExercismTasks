enum AccountType : byte
{
    Guest = 0b00000001,
    User = 0b00000011,
    Moderator = 0b00000111
}
[Flags]
enum Permission : byte
{
    Read = 0b00000001,
    Write = 0b00000010,
    Delete = 0b00000100,
    All = 0b00000111,
    None = 0b00000000
}

static class Permissions
{
    public static Permission Default(AccountType accountType) => Enum.IsDefined(typeof(AccountType), accountType) ? (Permission)accountType : Permission.None;

    public static Permission Grant(Permission current, Permission grant) => current | grant;

    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;

    public static bool Check(Permission current, Permission check) => current.HasFlag(check);
}
