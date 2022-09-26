<?xml version="1.0" encoding="utf-8"?>
<ThermalLabel Version="11.0" Width="4" Height="2" GapLength="0.125" MarkLength="0" OffsetLength="0" UnitType="Inch" LabelsPerRow="1" LabelsHorizontalGapLength="0" IsContinuous="False" PrintSpeed="" PrintMirror="False" CutAfterPrinting="False" BatchCut="1">
  <Items>
    <RectangleShapeItem X="0.0521" Y="0.0426" Width="3.8864" Height="1.9156" StrokeThickness="0.03" CornerRadius="0.03" />
    <TextItem Name="GTIN" X="1.7938" Y="1.6216" Expression="_x0022_Received_x0020_By_x0020__x0020__x0022__x0020__x002B__x0020__x005B_DataFields_x0021_firstname_x005D_" Width="1.9982" Height="0.2396" Font="ZPL Font 0,12,Point,,,False,90,,CP850" TextAlignment="Center" />
    <TextItem X="0.144" Y="0.1552" DataField="jobname" Width="1.8012" Height="0.7103" Font="ZPL Font 0,12,Point,,,False,90,,CP850" TextAlignment="Center" />
    <BarcodeItem X="2.1061" Y="0.16" DataField="StockTransactionID" Width="1.6752" Height="0.7025" Symbology="Code39" Code="" AddChecksum="False" BarcodeAlignment="MiddleCenter" Font="NativePrinterFontA,5,Point,,,False,90,,CP850" QuietZone="0" TextFont="NativePrinterFontA,10,Point,,,False,90,,CP850" MaxiCodeDrawPixelBasedSymbol="True" DotCodeAspectRatio="" />
    <LineShapeItem X="2.0162" Y="0.0634" Width="0.0047" Height="0.8798" StrokeThickness="0.03" Orientation="DiagonalDown" />
    <TextItem X="0.1601" Y="1.0186" DataField="Description" Width="3.662" Height="0.4824" Font="ZPL Font 0,12,Point,,,False,90,,CP850" TextAlignment="Center" />
    <LineShapeItem X="0.0685" Y="0.9457" Width="3.8552" Height="0.0047" StrokeThickness="0.03" Orientation="DiagonalUp" />
    <TextItem X="0.1802" Y="1.6141" DataField="ReceiptDate" Expression="FormatDateTime_x0028_CDate_x0028__x005B_DataFields_x0021_ReceiptDate_x005D__x0029__x002C__x0020__x0022_ShortDate_x0022__x0029_" Width="1.5539" Height="0.2471" Font="NativePrinterFontA,10,Point,,,False,90,,CP850" TextAlignment="Center" InputMaskPattern="00/00/0000" />
    <LineShapeItem X="0.0705" Y="1.5483" Width="3.8466" Height="0.03" StrokeThickness="0.03" />
  </Items>
</ThermalLabel>