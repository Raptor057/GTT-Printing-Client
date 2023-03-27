namespace GT.Trace.Labels.App.Dtos
{
    public class PickingLabelDto : LabelDto
    {
        public PickingLabelDto()
            : base(LabelTypes.Picking)
        {
        }

        public long UnitID { get; set; }

        public long ProtoID { get; set; }
    }
}