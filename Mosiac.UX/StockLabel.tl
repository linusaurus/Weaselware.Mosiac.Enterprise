<?xml version="1.0" encoding="utf-8"?>
<ThermalLabel Version="11.0" Width="4" Height="4" GapLength="0" MarkLength="0" OffsetLength="0" UnitType="Inch" LabelsPerRow="1" LabelsHorizontalGapLength="0" IsContinuous="False" PrintSpeed="" PrintMirror="False" CutAfterPrinting="False" BatchCut="1">
  <Items>
    <RectangleShapeItem X="0.0521" Y="0.0426" Locked="True" Width="3.8864" Height="3.9394" StrokeThickness="0.03" />
    <RectangleShapeItem X="0.1383" Y="3.2189" DataField="JobID" Width="1.3172" Height="0.6525" StrokeColor="White" FillColor="Black" />
    <TextItem Name="GTIN" X="1.7983" Y="1.8116" Expression="_x0022_Received_x0020_By_x0020__x0020__x0022__x0020__x002B__x0020__x005B_DataFields_x0021_firstname_x005D_" Width="1.9982" Height="0.2396" Font="ZPL Font 0,12,Point,,,False,90,,CP850" TextAlignment="Center" />
    <TextItem X="0.144" Y="0.1552" DataField="jobname" Width="1.8012" Height="0.7103" Font="ZPL Font 0,16,Point,,,False,90,,CP850" TextAlignment="Center" />
    <BarcodeItem X="2.1061" Y="0.1496" DataField="StockTransactionID" Width="1.6752" Height="0.7025" Symbology="GS1128" Code="" AddChecksum="False" BarcodeAlignment="MiddleCenter" DisplayCode="False" Font="NativePrinterFontA,5,Point,,,False,90,,CP850" QuietZone="0" TextFont="NativePrinterFontA,10,Point,,,False,90,,CP850" MaxiCodeDrawPixelBasedSymbol="True" DotCodeAspectRatio="" />
    <LineShapeItem X="2.0162" Y="0.0634" Width="0.0047" Height="0.8798" StrokeThickness="0.05" Orientation="DiagonalDown" />
    <TextItem X="0.1393" Y="0.9973" DataField="Description" Width="3.662" Height="0.6535" Font="ZPL Font 0,12,Point,,,False,90,,CP850" TextAlignment="Center" />
    <LineShapeItem X="0.0685" Y="0.9457" Width="3.8552" Height="0.0047" StrokeThickness="0.05" Orientation="DiagonalUp" />
    <TextItem X="0.1802" Y="1.8041" DataField="ReceiptDate" Expression="FormatDateTime_x0028_CDate_x0028__x005B_DataFields_x0021_ReceiptDate_x005D__x0029__x002C__x0020__x0022_ShortDate_x0022__x0029_" Width="1.5539" Height="0.2471" Font="NativePrinterFontA,10,Point,,,False,90,,CP850" TextAlignment="Center" InputMaskPattern="00/00/0000" />
    <TextItem X="0.1878" Y="3.3849" DataField="JobID" Width="1.1894" Height="0.3324" Font="NativePrinterFontA,16,Point,,,False,90,,CP850" ForeColor="White" TextAlignment="Center" />
    <LineShapeItem X="0.0705" Y="1.6883" Width="3.8466" Height="0.05" StrokeThickness="0.05" />
  </Items>
</ThermalLabel>