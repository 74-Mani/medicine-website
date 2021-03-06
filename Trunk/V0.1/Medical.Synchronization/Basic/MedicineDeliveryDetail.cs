///////////////////////////////////////////////////////////////////////////
// Description: Mapping class for the table 'MedicineDeliveryDetail'
///////////////////////////////////////////////////////////////////////////
using System;

namespace Medical.Synchronization.Basic
{
	/// <summary>
	/// Purpose: Mapping class for the table 'MedicineDeliveryDetail'.
	/// </summary>
	public class MedicineDeliveryDetail
	{
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MedicineDeliveryDetail()
		{
			// Nothing for now.
		}

        #region Class Property Declarations
        public long Id { get; set; }

        public long MedicineDeliveryId { get; set; }

        public long PrescriptionDetailId { get; set; }

        public int MedicineId { get; set; }

        public int Volumn { get; set; }

        public int Unit { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public int Version { get; set; }
		#endregion
	}
}
