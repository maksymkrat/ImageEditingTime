namespace Image_editing_C
{
    public class Worker
    {
        private int ImageEditingTime;

        public Worker(int imageEditingTime)
        {
            ImageEditingTime = imageEditingTime;
        }

        public int GetImageEditingTime()
        {
            return ImageEditingTime;
        }
        
    }
}