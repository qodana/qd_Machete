// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O34_ORDER (Group) - 
    /// </summary>
    public interface ORL_O34_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<ORL_O34_TIMING> Timing { get; }

        /// <summary>
        /// OBSERVATION_REQUEST
        /// </summary>
        Layout<ORL_O34_OBSERVATION_REQUEST> ObservationRequest { get; }
    }
}