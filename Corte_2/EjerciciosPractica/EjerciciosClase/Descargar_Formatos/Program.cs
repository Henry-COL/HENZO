using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

class Program
{
    static async Task Main(string[] args)
    {
        var youtube = new YoutubeClient();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("======================================");
        Console.WriteLine("    YOUTUBE DOWNLOADER A DESCARGAS    ");
        Console.WriteLine("======================================\n");
        Console.ResetColor();

        // 1. Pedir el Link
        Console.Write("Ingresa el link del video: ");
        string videoUrl = Console.ReadLine();

        try
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            Console.WriteLine($"\nVideo: {video.Title}");
            Console.WriteLine($"Duración: {video.Duration}\n");

            // 2. Pedir el Formato
            Console.WriteLine("Selecciona el formato:");
            Console.WriteLine("1. mp4 (Estándar)");
            Console.WriteLine("2. mp4 HD (Máxima calidad)");
            Console.WriteLine("3. mp3 (Audio)");
            Console.WriteLine("4. mp3 HD (Audio alta calidad)");
            Console.Write("\nOpción: ");
            string opcion = Console.ReadLine();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            IStreamInfo streamInfo = null;
            string extension = "mp4";

            switch (opcion)
            {
                case "1":
                    streamInfo = streamManifest.GetMuxedStreams().OrderBy(s => s.VideoQuality).FirstOrDefault();
                    extension = "mp4";
                    break;
                case "2":
                    streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    extension = "mp4";
                    break;
                case "3":
                    streamInfo = streamManifest.GetAudioOnlyStreams().OrderBy(s => s.Bitrate).FirstOrDefault();
                    extension = "mp3";
                    break;
                case "4":
                    streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    extension = "mp3";
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            if (streamInfo != null)
            {
                // 3. Configurar ruta automática a la carpeta de "Descargas"
                string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloadsFolder = Path.Combine(userPath, "Downloads");

                // Limpiar nombre de archivo (quitar caracteres que Windows no acepta)
                string safeTitle = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));
                string filePath = Path.Combine(downloadsFolder, $"{safeTitle}.{extension}");

                Console.WriteLine($"\nDescargando en: {downloadsFolder}");

                // 4. Descarga con barra de progreso en consola
                var progress = new Progress<double>(p => {
                    Console.Write($"\rProgreso: {p:P0} "); // Actualiza el porcentaje en la misma línea
                });

                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, progress);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n¡Descarga terminada con éxito!");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nError: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}