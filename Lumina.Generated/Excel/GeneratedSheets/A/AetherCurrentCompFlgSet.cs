using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherCurrentCompFlgSet", columnHash: 0xa562e4cf )]
    public class AetherCurrentCompFlgSet : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Territory;

        // col: 02 offset: 0004
        public int[] AetherCurrent;

        // col: 01 offset: 0040
        public byte unknown40;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Territory = parser.ReadOffset< int >( 0x0 );

            // col: 2 offset: 0004
            AetherCurrent = new int[15];
            AetherCurrent[0] = parser.ReadOffset< int >( 0x4 );
            AetherCurrent[1] = parser.ReadOffset< int >( 0x8 );
            AetherCurrent[2] = parser.ReadOffset< int >( 0xc );
            AetherCurrent[3] = parser.ReadOffset< int >( 0x10 );
            AetherCurrent[4] = parser.ReadOffset< int >( 0x14 );
            AetherCurrent[5] = parser.ReadOffset< int >( 0x18 );
            AetherCurrent[6] = parser.ReadOffset< int >( 0x1c );
            AetherCurrent[7] = parser.ReadOffset< int >( 0x20 );
            AetherCurrent[8] = parser.ReadOffset< int >( 0x24 );
            AetherCurrent[9] = parser.ReadOffset< int >( 0x28 );
            AetherCurrent[10] = parser.ReadOffset< int >( 0x2c );
            AetherCurrent[11] = parser.ReadOffset< int >( 0x30 );
            AetherCurrent[12] = parser.ReadOffset< int >( 0x34 );
            AetherCurrent[13] = parser.ReadOffset< int >( 0x38 );
            AetherCurrent[14] = parser.ReadOffset< int >( 0x3c );

            // col: 1 offset: 0040
            unknown40 = parser.ReadOffset< byte >( 0x40 );


        }
    }
}