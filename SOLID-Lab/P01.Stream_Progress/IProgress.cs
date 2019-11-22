namespace P01.Stream_Progress
{
    public interface IProgress
    {
         int Length { get; set; }

         int BytesSent { get; set; }
    }
}
