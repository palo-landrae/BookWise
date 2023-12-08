using BookWiseBusLogic.Context;

namespace BookWiseBusLogic.Manager
{
    public class BookingManager
    {
        private readonly BookWiseDBContext _context;

        public BookingManager()
        {
            _context = new BookWiseDBContext();
        }
    }
}
