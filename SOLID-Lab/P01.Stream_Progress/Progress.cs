namespace P01.Stream_Progress
{
    public abstract class Progress :IProgress
    {
        public  int Length { get; set; }
        public  int BytesSent { get; set; }
    }
}
