namespace Lab001.Interfaces
{
	public interface IBufferedFileUploadService
	{
		Task<bool> UploadFile(IFormFile file);
	}
}
