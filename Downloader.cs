using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace CerediraPackageManagerUI
{
    /// <summary>
    /// Класс для методов работы с сетью интернет. Размещаемые методы должны быть async,
    /// так как вызываются из UI потока и нельзя блокировать основной поток, или UI будет зависать.
    /// </summary>
    internal class Downloader
    {
        /// <summary>
        /// Метод для скачивания файла по ссылке
        /// </summary>
        /// <param name="url">URL ссылка скачиваемого файла</param>
        /// <param name="filePath">Путь в файловой системе, для сохранения скачанного файла</param>
        /// <returns>Возвращает асинхронную задачу, без данных</returns>
        /// <exception cref="Exception">Ошибки скачивания</exception>
        public static async Task DownloadFileAsync(string url, string filePath)
        {
            try
            {
                // Не очень хорошая штука, но нам беречь нечего. Этот код для обхода проблем
                // с самоподписными сертификатами.
                // Для лучшей безопасности handler лучше убрать вообще.
                var handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };
                using (var httpClient = new HttpClient(handler))
                {
                    var response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        using (var fileStream = File.Create(filePath))
                        {
                            await stream.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        throw new Exception($"Ошибка скачивания файла: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка скачивания файла: {ex.Message}");
            }
        }

        /// <summary>
        /// Метод для скачивания содержимого по ссылке
        /// </summary>
        /// <param name="url">URL ссылка скачиваемых данных</param>
        /// <returns>Асинхронная задача, возвращающая содержимое скачанное по ссылке</returns>
        /// <exception cref="Exception">Ошибки скачивания</exception>
        public static async Task<string> GetPageContentAsync(string url)
        {
            try
            {
                // Не очень хорошая штука, но нам беречь нечего. Этот код для обхода проблем
                // с самоподписными сертификатами.
                // Для лучшей безопасности handler лучше убрать вообще.
                var handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                using (var httpClient = new HttpClient(handler))
                {
                    var response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception($"Ошибка получения данных по ссылке {url}. Статус код: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка получения данных по ссылке {url}: {ex.Message}");
            }
        }
    }
}
