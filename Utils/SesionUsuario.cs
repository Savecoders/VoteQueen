namespace UgVoteQueen.Helpers
{
    public static class SesionUsuario
    {
        public static int Id { get; set; }
        public static string Nombre { get; set; } = string.Empty;
        public static string Correo { get; set; } = string.Empty;
        public static byte[] FotoPerfil { get; set; } = [];
    }
}