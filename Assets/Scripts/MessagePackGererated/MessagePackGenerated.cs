#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Resolvers
{
    using System;
    using MessagePack;

    public class GeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new GeneratedResolver();

        GeneratedResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(114)
            {
                {typeof(global::MyTransform[]), 0 },
                {typeof(global::MultiTransform[]), 1 },
                {typeof(global::HoloToolkit.Unity.Handedness), 2 },
                {typeof(global::BoundsExtensions.Axis), 3 },
                {typeof(global::HoloToolkit.Unity.InputModule.AnimCursorDatum.AnimInputTypeEnum), 4 },
                {typeof(global::HoloToolkit.Unity.InputModule.CursorStateEnum), 5 },
                {typeof(global::HoloToolkit.Unity.InputModule.XboxControllerMappingTypes), 6 },
                {typeof(global::HoloToolkit.Unity.InputModule.InteractionInputSource.RecognizerStartBehavior), 7 },
                {typeof(global::HoloToolkit.Unity.InputModule.InteractionSourceInfo), 8 },
                {typeof(global::HoloToolkit.Unity.InputModule.InteractionSourcePressInfo), 9 },
                {typeof(global::HoloToolkit.Unity.InputModule.SpeechInputSource.SpeechRecognizerStartBehavior), 10 },
                {typeof(global::HoloToolkit.Unity.InputModule.SupportedInputInfo), 11 },
                {typeof(global::HoloToolkit.Unity.InputModule.AxisController.AxisType), 12 },
                {typeof(global::HoloToolkit.Unity.InputModule.AxisController.AxisDestination), 13 },
                {typeof(global::HoloToolkit.Unity.InputModule.ButtonController.ButtonType), 14 },
                {typeof(global::HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraint), 15 },
                {typeof(global::HoloToolkit.Unity.InputModule.HandDraggable.RotationModeEnum), 16 },
                {typeof(global::HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationMode), 17 },
                {typeof(global::HoloToolkit.Unity.InputModule.KeyboardManager.KeyEvent), 18 },
                {typeof(global::HoloToolkit.Unity.InputModule.MixedRealityCameraManager.DisplayType), 19 },
                {typeof(global::HoloToolkit.Unity.MicrophoneStatus), 20 },
                {typeof(global::HoloToolkit.Unity.InputModule.MicStream.StreamCategory), 21 },
                {typeof(global::HoloToolkit.Unity.InputModule.MicStream.ErrorCodes), 22 },
                {typeof(global::HoloToolkit.Unity.InputModule.MotionControllerInfo.ControllerElementEnum), 23 },
                {typeof(global::HoloToolkit.Sharing.ClientRole), 24 },
                {typeof(global::HoloToolkit.Sharing.ElementType), 25 },
                {typeof(global::HoloToolkit.Sharing.LogSeverity), 26 },
                {typeof(global::HoloToolkit.Sharing.MachineSessionState), 27 },
                {typeof(global::HoloToolkit.Sharing.MessageChannel), 28 },
                {typeof(global::HoloToolkit.Sharing.MessageID), 29 },
                {typeof(global::HoloToolkit.Sharing.MessagePriority), 30 },
                {typeof(global::HoloToolkit.Sharing.MessageReliability), 31 },
                {typeof(global::HoloToolkit.Sharing.PairingResult), 32 },
                {typeof(global::HoloToolkit.Sharing.SessionType), 33 },
                {typeof(global::HoloToolkit.Sharing.SystemRole), 34 },
                {typeof(global::HoloToolkit.Sharing.Utilities.DirectPairing.Role), 35 },
                {typeof(global::HoloToolkit.Unity.SpatialMapping.ObserverStates), 36 },
                {typeof(global::HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypes), 37 },
                {typeof(global::HoloToolkit.Unity.SpatialMapping.PlaneTypes), 38 },
                {typeof(global::HoloToolkit.Unity.AudioLoFiSourceQuality), 39 },
                {typeof(global::HoloToolkit.Unity.AudioContainerType), 40 },
                {typeof(global::HoloToolkit.Unity.AudioEventInstanceBehavior), 41 },
                {typeof(global::HoloToolkit.Unity.SpatialPositioningType), 42 },
                {typeof(global::HoloToolkit.Unity.SpatialSoundRoomSizes), 43 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstanding.ScanStates), 44 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDll.Imports.RaycastResult.SurfaceTypes), 45 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.PlacementType), 46 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.WallTypeFlags), 47 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementRule.ObjectPlacementRuleType), 48 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementConstraint.ObjectPlacementConstraintType), 49 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeComponentConstraintType), 50 },
                {typeof(global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeConstraintType), 51 },
                {typeof(global::HoloToolkit.Unity.GradientDefaultAttribute.ColorEnum), 52 },
                {typeof(global::HoloToolkit.Unity.MaterialPropertyAttribute.PropertyTypeEnum), 53 },
                {typeof(global::HoloToolkit.Unity.RangePropAttribute.TypeEnum), 54 },
                {typeof(global::HoloToolkit.Unity.ValidateUnityObjectAttribute.ActionEnum), 55 },
                {typeof(global::HoloToolkit.Unity.PivotAxis), 56 },
                {typeof(global::UnityGLTF.GLTFSceneImporter.MaterialType), 57 },
                {typeof(global::HoloToolkit.Unity.SolverBodyLock.OrientationReference), 58 },
                {typeof(global::HoloToolkit.Unity.SolverConstantViewSize.ScaleStateEnum), 59 },
                {typeof(global::HoloToolkit.Unity.SolverHandler.TrackedObjectToReferenceEnum), 60 },
                {typeof(global::HoloToolkit.Unity.SolverOrbital.OrientationReferenceEnum), 61 },
                {typeof(global::HoloToolkit.Unity.SolverRadialView.ReferenceDirectionEnum), 62 },
                {typeof(global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastDirectionEnum), 63 },
                {typeof(global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastModeEnum), 64 },
                {typeof(global::HoloToolkit.Unity.SolverSurfaceMagnetism.OrientModeEnum), 65 },
                {typeof(global::HoloToolkit.Unity.TextToSpeechVoice), 66 },
                {typeof(global::HoloToolkit.Unity.UX.AppBar.ButtonTypeEnum), 67 },
                {typeof(global::HoloToolkit.Unity.UX.AppBar.AppBarDisplayTypeEnum), 68 },
                {typeof(global::HoloToolkit.Unity.UX.AppBar.AppBarStateEnum), 69 },
                {typeof(global::HoloToolkit.UI.Keyboard.AxisSlider.EAxis), 70 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBox.BoundsCalculationMethodEnum), 71 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBox.FlattenModeEnum), 72 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffect), 73 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionType), 74 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationType), 75 },
                {typeof(global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformType), 76 },
                {typeof(global::HoloToolkit.Unity.UX.Duplicator.StateEnum), 77 },
                {typeof(global::HoloToolkit.Unity.UX.Duplicator.ActivateModeEnum), 78 },
                {typeof(global::HoloToolkit.Unity.Buttons.ButtonStateEnum), 79 },
                {typeof(global::HoloToolkit.UX.Dialog.DialogButtonType), 80 },
                {typeof(global::HoloToolkit.Unity.Buttons.ToggleBehaviorEnum), 81 },
                {typeof(global::HoloToolkit.Unity.Buttons.CompoundButtonSpeech.KeywordSourceEnum), 82 },
                {typeof(global::HoloToolkit.Unity.Collections.LayoutTypeEnum), 83 },
                {typeof(global::HoloToolkit.Unity.Collections.OrientTypeEnum), 84 },
                {typeof(global::HoloToolkit.Unity.Collections.SortTypeEnum), 85 },
                {typeof(global::HoloToolkit.Unity.Collections.SurfaceTypeEnum), 86 },
                {typeof(global::HoloToolkit.Unity.Collections.ObjectCollectionDynamic.BehaviorEnum), 87 },
                {typeof(global::HoloToolkit.UX.Dialog.DialogState), 88 },
                {typeof(global::HoloToolkit.UI.Keyboard.Keyboard.LayoutType), 89 },
                {typeof(global::HoloToolkit.UI.Keyboard.KeyboardKeyFunc.Function), 90 },
                {typeof(global::HoloToolkit.Unity.UX.InterpolationEnum), 91 },
                {typeof(global::HoloToolkit.Unity.UX.RotationTypeEnum), 92 },
                {typeof(global::HoloToolkit.Unity.UX.PointDistributionTypeEnum), 93 },
                {typeof(global::HoloToolkit.Unity.UX.StepModeEnum), 94 },
                {typeof(global::HoloToolkit.Unity.UX.InterpolationModeEnum), 95 },
                {typeof(global::HoloToolkit.Unity.UX.DistortionTypeEnum), 96 },
                {typeof(global::HoloToolkit.UX.Progress.IndicatorStyleEnum), 97 },
                {typeof(global::HoloToolkit.UX.Progress.ProgressMessageStyleEnum), 98 },
                {typeof(global::HoloToolkit.UX.Progress.ProgressStyleEnum), 99 },
                {typeof(global::HoloToolkit.UX.ToolTips.ToolTipAttachPointType), 100 },
                {typeof(global::HoloToolkit.UX.ToolTips.ConnectorFollowType), 101 },
                {typeof(global::HoloToolkit.UX.ToolTips.ConnectorOrientType), 102 },
                {typeof(global::HoloToolkit.UX.ToolTips.ConnnectorPivotMode), 103 },
                {typeof(global::HoloToolkit.UX.ToolTips.ConnectorPivotDirection), 104 },
                {typeof(global::HoloToolkit.UX.ToolTips.TipDisplayModeEnum), 105 },
                {typeof(global::HoloToolkit.UX.ToolTips.ToolTipSpawner.RemainType), 106 },
                {typeof(global::MessagePack.MessagePackType), 107 },
                {typeof(global::EVENT_TYPE), 108 },
                {typeof(global::MyClass), 109 },
                {typeof(global::MyTransform), 110 },
                {typeof(global::MsgPackSend), 111 },
                {typeof(global::MultiTransform), 112 },
                {typeof(global::MsgPackMultiTransformSend), 113 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::MessagePack.Formatters.ArrayFormatter<global::MyTransform>();
                case 1: return new global::MessagePack.Formatters.ArrayFormatter<global::MultiTransform>();
                case 2: return new MessagePack.Formatters.HoloToolkit.Unity.HandednessFormatter();
                case 3: return new MessagePack.Formatters.AxisFormatter();
                case 4: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.AnimInputTypeEnumFormatter();
                case 5: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.CursorStateEnumFormatter();
                case 6: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.XboxControllerMappingTypesFormatter();
                case 7: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.RecognizerStartBehaviorFormatter();
                case 8: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.InteractionSourceInfoFormatter();
                case 9: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.InteractionSourcePressInfoFormatter();
                case 10: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.SpeechRecognizerStartBehaviorFormatter();
                case 11: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.SupportedInputInfoFormatter();
                case 12: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.AxisTypeFormatter();
                case 13: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.AxisDestinationFormatter();
                case 14: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.ButtonTypeFormatter();
                case 15: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraintFormatter();
                case 16: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.RotationModeEnumFormatter();
                case 17: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationModeFormatter();
                case 18: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.KeyEventFormatter();
                case 19: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.DisplayTypeFormatter();
                case 20: return new MessagePack.Formatters.HoloToolkit.Unity.MicrophoneStatusFormatter();
                case 21: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.StreamCategoryFormatter();
                case 22: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.ErrorCodesFormatter();
                case 23: return new MessagePack.Formatters.HoloToolkit.Unity.InputModule.ControllerElementEnumFormatter();
                case 24: return new MessagePack.Formatters.HoloToolkit.Sharing.ClientRoleFormatter();
                case 25: return new MessagePack.Formatters.HoloToolkit.Sharing.ElementTypeFormatter();
                case 26: return new MessagePack.Formatters.HoloToolkit.Sharing.LogSeverityFormatter();
                case 27: return new MessagePack.Formatters.HoloToolkit.Sharing.MachineSessionStateFormatter();
                case 28: return new MessagePack.Formatters.HoloToolkit.Sharing.MessageChannelFormatter();
                case 29: return new MessagePack.Formatters.HoloToolkit.Sharing.MessageIDFormatter();
                case 30: return new MessagePack.Formatters.HoloToolkit.Sharing.MessagePriorityFormatter();
                case 31: return new MessagePack.Formatters.HoloToolkit.Sharing.MessageReliabilityFormatter();
                case 32: return new MessagePack.Formatters.HoloToolkit.Sharing.PairingResultFormatter();
                case 33: return new MessagePack.Formatters.HoloToolkit.Sharing.SessionTypeFormatter();
                case 34: return new MessagePack.Formatters.HoloToolkit.Sharing.SystemRoleFormatter();
                case 35: return new MessagePack.Formatters.HoloToolkit.Sharing.Utilities.RoleFormatter();
                case 36: return new MessagePack.Formatters.HoloToolkit.Unity.SpatialMapping.ObserverStatesFormatter();
                case 37: return new MessagePack.Formatters.HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypesFormatter();
                case 38: return new MessagePack.Formatters.HoloToolkit.Unity.SpatialMapping.PlaneTypesFormatter();
                case 39: return new MessagePack.Formatters.HoloToolkit.Unity.AudioLoFiSourceQualityFormatter();
                case 40: return new MessagePack.Formatters.HoloToolkit.Unity.AudioContainerTypeFormatter();
                case 41: return new MessagePack.Formatters.HoloToolkit.Unity.AudioEventInstanceBehaviorFormatter();
                case 42: return new MessagePack.Formatters.HoloToolkit.Unity.SpatialPositioningTypeFormatter();
                case 43: return new MessagePack.Formatters.HoloToolkit.Unity.SpatialSoundRoomSizesFormatter();
                case 44: return new MessagePack.Formatters.HoloToolkit.Unity.ScanStatesFormatter();
                case 45: return new MessagePack.Formatters.HoloToolkit.Unity.SurfaceTypesFormatter();
                case 46: return new MessagePack.Formatters.HoloToolkit.Unity.PlacementTypeFormatter();
                case 47: return new MessagePack.Formatters.HoloToolkit.Unity.WallTypeFlagsFormatter();
                case 48: return new MessagePack.Formatters.HoloToolkit.Unity.ObjectPlacementRuleTypeFormatter();
                case 49: return new MessagePack.Formatters.HoloToolkit.Unity.ObjectPlacementConstraintTypeFormatter();
                case 50: return new MessagePack.Formatters.HoloToolkit.Unity.ShapeComponentConstraintTypeFormatter();
                case 51: return new MessagePack.Formatters.HoloToolkit.Unity.ShapeConstraintTypeFormatter();
                case 52: return new MessagePack.Formatters.HoloToolkit.Unity.ColorEnumFormatter();
                case 53: return new MessagePack.Formatters.HoloToolkit.Unity.PropertyTypeEnumFormatter();
                case 54: return new MessagePack.Formatters.HoloToolkit.Unity.TypeEnumFormatter();
                case 55: return new MessagePack.Formatters.HoloToolkit.Unity.ActionEnumFormatter();
                case 56: return new MessagePack.Formatters.HoloToolkit.Unity.PivotAxisFormatter();
                case 57: return new MessagePack.Formatters.UnityGLTF.MaterialTypeFormatter();
                case 58: return new MessagePack.Formatters.HoloToolkit.Unity.OrientationReferenceFormatter();
                case 59: return new MessagePack.Formatters.HoloToolkit.Unity.ScaleStateEnumFormatter();
                case 60: return new MessagePack.Formatters.HoloToolkit.Unity.TrackedObjectToReferenceEnumFormatter();
                case 61: return new MessagePack.Formatters.HoloToolkit.Unity.OrientationReferenceEnumFormatter();
                case 62: return new MessagePack.Formatters.HoloToolkit.Unity.ReferenceDirectionEnumFormatter();
                case 63: return new MessagePack.Formatters.HoloToolkit.Unity.RaycastDirectionEnumFormatter();
                case 64: return new MessagePack.Formatters.HoloToolkit.Unity.RaycastModeEnumFormatter();
                case 65: return new MessagePack.Formatters.HoloToolkit.Unity.OrientModeEnumFormatter();
                case 66: return new MessagePack.Formatters.HoloToolkit.Unity.TextToSpeechVoiceFormatter();
                case 67: return new MessagePack.Formatters.HoloToolkit.Unity.UX.ButtonTypeEnumFormatter();
                case 68: return new MessagePack.Formatters.HoloToolkit.Unity.UX.AppBarDisplayTypeEnumFormatter();
                case 69: return new MessagePack.Formatters.HoloToolkit.Unity.UX.AppBarStateEnumFormatter();
                case 70: return new MessagePack.Formatters.HoloToolkit.UI.Keyboard.EAxisFormatter();
                case 71: return new MessagePack.Formatters.HoloToolkit.Unity.UX.BoundsCalculationMethodEnumFormatter();
                case 72: return new MessagePack.Formatters.HoloToolkit.Unity.UX.FlattenModeEnumFormatter();
                case 73: return new MessagePack.Formatters.HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffectFormatter();
                case 74: return new MessagePack.Formatters.HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionTypeFormatter();
                case 75: return new MessagePack.Formatters.HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationTypeFormatter();
                case 76: return new MessagePack.Formatters.HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformTypeFormatter();
                case 77: return new MessagePack.Formatters.HoloToolkit.Unity.UX.StateEnumFormatter();
                case 78: return new MessagePack.Formatters.HoloToolkit.Unity.UX.ActivateModeEnumFormatter();
                case 79: return new MessagePack.Formatters.HoloToolkit.Unity.Buttons.ButtonStateEnumFormatter();
                case 80: return new MessagePack.Formatters.HoloToolkit.UX.Dialog.DialogButtonTypeFormatter();
                case 81: return new MessagePack.Formatters.HoloToolkit.Unity.Buttons.ToggleBehaviorEnumFormatter();
                case 82: return new MessagePack.Formatters.HoloToolkit.Unity.Buttons.KeywordSourceEnumFormatter();
                case 83: return new MessagePack.Formatters.HoloToolkit.Unity.Collections.LayoutTypeEnumFormatter();
                case 84: return new MessagePack.Formatters.HoloToolkit.Unity.Collections.OrientTypeEnumFormatter();
                case 85: return new MessagePack.Formatters.HoloToolkit.Unity.Collections.SortTypeEnumFormatter();
                case 86: return new MessagePack.Formatters.HoloToolkit.Unity.Collections.SurfaceTypeEnumFormatter();
                case 87: return new MessagePack.Formatters.HoloToolkit.Unity.Collections.BehaviorEnumFormatter();
                case 88: return new MessagePack.Formatters.HoloToolkit.UX.Dialog.DialogStateFormatter();
                case 89: return new MessagePack.Formatters.HoloToolkit.UI.Keyboard.LayoutTypeFormatter();
                case 90: return new MessagePack.Formatters.HoloToolkit.UI.Keyboard.FunctionFormatter();
                case 91: return new MessagePack.Formatters.HoloToolkit.Unity.UX.InterpolationEnumFormatter();
                case 92: return new MessagePack.Formatters.HoloToolkit.Unity.UX.RotationTypeEnumFormatter();
                case 93: return new MessagePack.Formatters.HoloToolkit.Unity.UX.PointDistributionTypeEnumFormatter();
                case 94: return new MessagePack.Formatters.HoloToolkit.Unity.UX.StepModeEnumFormatter();
                case 95: return new MessagePack.Formatters.HoloToolkit.Unity.UX.InterpolationModeEnumFormatter();
                case 96: return new MessagePack.Formatters.HoloToolkit.Unity.UX.DistortionTypeEnumFormatter();
                case 97: return new MessagePack.Formatters.HoloToolkit.UX.Progress.IndicatorStyleEnumFormatter();
                case 98: return new MessagePack.Formatters.HoloToolkit.UX.Progress.ProgressMessageStyleEnumFormatter();
                case 99: return new MessagePack.Formatters.HoloToolkit.UX.Progress.ProgressStyleEnumFormatter();
                case 100: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.ToolTipAttachPointTypeFormatter();
                case 101: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.ConnectorFollowTypeFormatter();
                case 102: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.ConnectorOrientTypeFormatter();
                case 103: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.ConnnectorPivotModeFormatter();
                case 104: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.ConnectorPivotDirectionFormatter();
                case 105: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.TipDisplayModeEnumFormatter();
                case 106: return new MessagePack.Formatters.HoloToolkit.UX.ToolTips.RemainTypeFormatter();
                case 107: return new MessagePack.Formatters.MessagePack.MessagePackTypeFormatter();
                case 108: return new MessagePack.Formatters.EVENT_TYPEFormatter();
                case 109: return new MessagePack.Formatters.MyClassFormatter();
                case 110: return new MessagePack.Formatters.MyTransformFormatter();
                case 111: return new MessagePack.Formatters.MsgPackSendFormatter();
                case 112: return new MessagePack.Formatters.MultiTransformFormatter();
                case 113: return new MessagePack.Formatters.MsgPackMultiTransformSendFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity
{
    using System;
    using MessagePack;

    public sealed class HandednessFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Handedness>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Handedness value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Handedness Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Handedness)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MicrophoneStatusFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.MicrophoneStatus>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.MicrophoneStatus value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.MicrophoneStatus Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.MicrophoneStatus)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AudioLoFiSourceQualityFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.AudioLoFiSourceQuality>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.AudioLoFiSourceQuality value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.AudioLoFiSourceQuality Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.AudioLoFiSourceQuality)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AudioContainerTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.AudioContainerType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.AudioContainerType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.AudioContainerType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.AudioContainerType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AudioEventInstanceBehaviorFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.AudioEventInstanceBehavior>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.AudioEventInstanceBehavior value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.AudioEventInstanceBehavior Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.AudioEventInstanceBehavior)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SpatialPositioningTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialPositioningType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialPositioningType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialPositioningType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialPositioningType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SpatialSoundRoomSizesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialSoundRoomSizes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialSoundRoomSizes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialSoundRoomSizes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialSoundRoomSizes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ScanStatesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstanding.ScanStates>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstanding.ScanStates value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstanding.ScanStates Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstanding.ScanStates)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SurfaceTypesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDll.Imports.RaycastResult.SurfaceTypes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDll.Imports.RaycastResult.SurfaceTypes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDll.Imports.RaycastResult.SurfaceTypes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDll.Imports.RaycastResult.SurfaceTypes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PlacementTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.PlacementType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.PlacementType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.PlacementType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.PlacementType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class WallTypeFlagsFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.WallTypeFlags>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.WallTypeFlags value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.WallTypeFlags Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementDefinition.WallTypeFlags)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ObjectPlacementRuleTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementRule.ObjectPlacementRuleType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementRule.ObjectPlacementRuleType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementRule.ObjectPlacementRuleType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementRule.ObjectPlacementRuleType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ObjectPlacementConstraintTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementConstraint.ObjectPlacementConstraintType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementConstraint.ObjectPlacementConstraintType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementConstraint.ObjectPlacementConstraintType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllObjectPlacement.ObjectPlacementConstraint.ObjectPlacementConstraintType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ShapeComponentConstraintTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeComponentConstraintType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeComponentConstraintType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeComponentConstraintType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeComponentConstraintType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ShapeConstraintTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeConstraintType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeConstraintType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeConstraintType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialUnderstandingDllShapes.ShapeConstraintType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ColorEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.GradientDefaultAttribute.ColorEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.GradientDefaultAttribute.ColorEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.GradientDefaultAttribute.ColorEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.GradientDefaultAttribute.ColorEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PropertyTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.MaterialPropertyAttribute.PropertyTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.MaterialPropertyAttribute.PropertyTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.MaterialPropertyAttribute.PropertyTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.MaterialPropertyAttribute.PropertyTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class TypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.RangePropAttribute.TypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.RangePropAttribute.TypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.RangePropAttribute.TypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.RangePropAttribute.TypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ActionEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.ValidateUnityObjectAttribute.ActionEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.ValidateUnityObjectAttribute.ActionEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.ValidateUnityObjectAttribute.ActionEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.ValidateUnityObjectAttribute.ActionEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PivotAxisFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.PivotAxis>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.PivotAxis value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.PivotAxis Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.PivotAxis)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class OrientationReferenceFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverBodyLock.OrientationReference>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverBodyLock.OrientationReference value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverBodyLock.OrientationReference Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverBodyLock.OrientationReference)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ScaleStateEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverConstantViewSize.ScaleStateEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverConstantViewSize.ScaleStateEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverConstantViewSize.ScaleStateEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverConstantViewSize.ScaleStateEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class TrackedObjectToReferenceEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverHandler.TrackedObjectToReferenceEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverHandler.TrackedObjectToReferenceEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverHandler.TrackedObjectToReferenceEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverHandler.TrackedObjectToReferenceEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class OrientationReferenceEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverOrbital.OrientationReferenceEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverOrbital.OrientationReferenceEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverOrbital.OrientationReferenceEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverOrbital.OrientationReferenceEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ReferenceDirectionEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverRadialView.ReferenceDirectionEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverRadialView.ReferenceDirectionEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverRadialView.ReferenceDirectionEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverRadialView.ReferenceDirectionEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RaycastDirectionEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastDirectionEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastDirectionEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastDirectionEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastDirectionEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RaycastModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverSurfaceMagnetism.RaycastModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class OrientModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SolverSurfaceMagnetism.OrientModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SolverSurfaceMagnetism.OrientModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SolverSurfaceMagnetism.OrientModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SolverSurfaceMagnetism.OrientModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class TextToSpeechVoiceFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.TextToSpeechVoice>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.TextToSpeechVoice value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.TextToSpeechVoice Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.TextToSpeechVoice)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters
{
    using System;
    using MessagePack;

    public sealed class AxisFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::BoundsExtensions.Axis>
    {
        public int Serialize(ref byte[] bytes, int offset, global::BoundsExtensions.Axis value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::BoundsExtensions.Axis Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::BoundsExtensions.Axis)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class EVENT_TYPEFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::EVENT_TYPE>
    {
        public int Serialize(ref byte[] bytes, int offset, global::EVENT_TYPE value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::EVENT_TYPE Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::EVENT_TYPE)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.InputModule
{
    using System;
    using MessagePack;

    public sealed class AnimInputTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.AnimCursorDatum.AnimInputTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.AnimCursorDatum.AnimInputTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.AnimCursorDatum.AnimInputTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.AnimCursorDatum.AnimInputTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class CursorStateEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.CursorStateEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.CursorStateEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.CursorStateEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.CursorStateEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class XboxControllerMappingTypesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.XboxControllerMappingTypes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.XboxControllerMappingTypes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.XboxControllerMappingTypes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.XboxControllerMappingTypes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RecognizerStartBehaviorFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.InteractionInputSource.RecognizerStartBehavior>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.InteractionInputSource.RecognizerStartBehavior value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.InteractionInputSource.RecognizerStartBehavior Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.InteractionInputSource.RecognizerStartBehavior)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class InteractionSourceInfoFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.InteractionSourceInfo>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.InteractionSourceInfo value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.InteractionSourceInfo Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.InteractionSourceInfo)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class InteractionSourcePressInfoFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.InteractionSourcePressInfo>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.InteractionSourcePressInfo value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.InteractionSourcePressInfo Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.InteractionSourcePressInfo)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SpeechRecognizerStartBehaviorFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.SpeechInputSource.SpeechRecognizerStartBehavior>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.SpeechInputSource.SpeechRecognizerStartBehavior value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.SpeechInputSource.SpeechRecognizerStartBehavior Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.SpeechInputSource.SpeechRecognizerStartBehavior)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SupportedInputInfoFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.SupportedInputInfo>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.SupportedInputInfo value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.SupportedInputInfo Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.SupportedInputInfo)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AxisTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.AxisController.AxisType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.AxisController.AxisType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.AxisController.AxisType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.AxisController.AxisType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AxisDestinationFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.AxisController.AxisDestination>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.AxisController.AxisDestination value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.AxisController.AxisDestination Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.AxisController.AxisDestination)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ButtonTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.ButtonController.ButtonType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.ButtonController.ButtonType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.ButtonController.ButtonType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.ButtonController.ButtonType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RotationModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.HandDraggable.RotationModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.HandDraggable.RotationModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.HandDraggable.RotationModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.HandDraggable.RotationModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class KeyEventFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.KeyboardManager.KeyEvent>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.KeyboardManager.KeyEvent value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.KeyboardManager.KeyEvent Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.KeyboardManager.KeyEvent)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class DisplayTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.MixedRealityCameraManager.DisplayType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.MixedRealityCameraManager.DisplayType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.MixedRealityCameraManager.DisplayType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.MixedRealityCameraManager.DisplayType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class StreamCategoryFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.MicStream.StreamCategory>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.MicStream.StreamCategory value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.MicStream.StreamCategory Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.MicStream.StreamCategory)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ErrorCodesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.MicStream.ErrorCodes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.MicStream.ErrorCodes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.MicStream.ErrorCodes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.MicStream.ErrorCodes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ControllerElementEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.MotionControllerInfo.ControllerElementEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.MotionControllerInfo.ControllerElementEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.MotionControllerInfo.ControllerElementEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.MotionControllerInfo.ControllerElementEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.InputModule.Utilities.Interactions
{
    using System;
    using MessagePack;

    public sealed class AxisConstraintFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraint>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraint value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraint Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.Utilities.Interactions.AxisConstraint)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ManipulationModeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationMode>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationMode value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationMode Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.InputModule.Utilities.Interactions.ManipulationMode)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Sharing
{
    using System;
    using MessagePack;

    public sealed class ClientRoleFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.ClientRole>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.ClientRole value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.ClientRole Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.ClientRole)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ElementTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.ElementType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.ElementType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.ElementType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.ElementType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class LogSeverityFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.LogSeverity>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.LogSeverity value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.LogSeverity Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.LogSeverity)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MachineSessionStateFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.MachineSessionState>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.MachineSessionState value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.MachineSessionState Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.MachineSessionState)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MessageChannelFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.MessageChannel>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.MessageChannel value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.MessageChannel Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.MessageChannel)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MessageIDFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.MessageID>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.MessageID value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.MessageID Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.MessageID)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MessagePriorityFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.MessagePriority>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.MessagePriority value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.MessagePriority Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.MessagePriority)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class MessageReliabilityFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.MessageReliability>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.MessageReliability value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.MessageReliability Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.MessageReliability)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PairingResultFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.PairingResult>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.PairingResult value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.PairingResult Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.PairingResult)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SessionTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.SessionType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.SessionType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.SessionType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.SessionType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SystemRoleFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.SystemRole>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.SystemRole value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.SystemRole Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.SystemRole)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Sharing.Utilities
{
    using System;
    using MessagePack;

    public sealed class RoleFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Sharing.Utilities.DirectPairing.Role>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Sharing.Utilities.DirectPairing.Role value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Sharing.Utilities.DirectPairing.Role Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Sharing.Utilities.DirectPairing.Role)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.SpatialMapping
{
    using System;
    using MessagePack;

    public sealed class ObserverStatesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialMapping.ObserverStates>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialMapping.ObserverStates value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialMapping.ObserverStates Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialMapping.ObserverStates)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ObserverVolumeTypesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialMapping.ObserverVolumeTypes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PlaneTypesFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.SpatialMapping.PlaneTypes>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.SpatialMapping.PlaneTypes value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.SpatialMapping.PlaneTypes Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.SpatialMapping.PlaneTypes)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.UnityGLTF
{
    using System;
    using MessagePack;

    public sealed class MaterialTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::UnityGLTF.GLTFSceneImporter.MaterialType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::UnityGLTF.GLTFSceneImporter.MaterialType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::UnityGLTF.GLTFSceneImporter.MaterialType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::UnityGLTF.GLTFSceneImporter.MaterialType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.UX
{
    using System;
    using MessagePack;

    public sealed class ButtonTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.AppBar.ButtonTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.AppBar.ButtonTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.AppBar.ButtonTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.AppBar.ButtonTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AppBarDisplayTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.AppBar.AppBarDisplayTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.AppBar.AppBarDisplayTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.AppBar.AppBarDisplayTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.AppBar.AppBarDisplayTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class AppBarStateEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.AppBar.AppBarStateEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.AppBar.AppBarStateEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.AppBar.AppBarStateEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.AppBar.AppBarStateEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BoundsCalculationMethodEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBox.BoundsCalculationMethodEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBox.BoundsCalculationMethodEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBox.BoundsCalculationMethodEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBox.BoundsCalculationMethodEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class FlattenModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBox.FlattenModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBox.FlattenModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBox.FlattenModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBox.FlattenModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BoundingBoxGizmoHandleAxisToAffectFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffect>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffect value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffect Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleAxisToAffect)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BoundingBoxGizmoHandleHandMotionTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleHandMotionType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BoundingBoxGizmoHandleRotationTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleRotationType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BoundingBoxGizmoHandleTransformTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.BoundingBoxGizmoHandleTransformType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class StateEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.Duplicator.StateEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.Duplicator.StateEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.Duplicator.StateEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.Duplicator.StateEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ActivateModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.Duplicator.ActivateModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.Duplicator.ActivateModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.Duplicator.ActivateModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.Duplicator.ActivateModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class InterpolationEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.InterpolationEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.InterpolationEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.InterpolationEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.InterpolationEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RotationTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.RotationTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.RotationTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.RotationTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.RotationTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class PointDistributionTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.PointDistributionTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.PointDistributionTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.PointDistributionTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.PointDistributionTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class StepModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.StepModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.StepModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.StepModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.StepModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class InterpolationModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.InterpolationModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.InterpolationModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.InterpolationModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.InterpolationModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class DistortionTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.UX.DistortionTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.UX.DistortionTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.UX.DistortionTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.UX.DistortionTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.UI.Keyboard
{
    using System;
    using MessagePack;

    public sealed class EAxisFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UI.Keyboard.AxisSlider.EAxis>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UI.Keyboard.AxisSlider.EAxis value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UI.Keyboard.AxisSlider.EAxis Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UI.Keyboard.AxisSlider.EAxis)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class LayoutTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UI.Keyboard.Keyboard.LayoutType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UI.Keyboard.Keyboard.LayoutType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UI.Keyboard.Keyboard.LayoutType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UI.Keyboard.Keyboard.LayoutType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class FunctionFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UI.Keyboard.KeyboardKeyFunc.Function>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UI.Keyboard.KeyboardKeyFunc.Function value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UI.Keyboard.KeyboardKeyFunc.Function Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UI.Keyboard.KeyboardKeyFunc.Function)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.Buttons
{
    using System;
    using MessagePack;

    public sealed class ButtonStateEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Buttons.ButtonStateEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Buttons.ButtonStateEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Buttons.ButtonStateEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Buttons.ButtonStateEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ToggleBehaviorEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Buttons.ToggleBehaviorEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Buttons.ToggleBehaviorEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Buttons.ToggleBehaviorEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Buttons.ToggleBehaviorEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class KeywordSourceEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Buttons.CompoundButtonSpeech.KeywordSourceEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Buttons.CompoundButtonSpeech.KeywordSourceEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Buttons.CompoundButtonSpeech.KeywordSourceEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Buttons.CompoundButtonSpeech.KeywordSourceEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.UX.Dialog
{
    using System;
    using MessagePack;

    public sealed class DialogButtonTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.Dialog.DialogButtonType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.Dialog.DialogButtonType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.Dialog.DialogButtonType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.Dialog.DialogButtonType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class DialogStateFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.Dialog.DialogState>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.Dialog.DialogState value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.Dialog.DialogState Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.Dialog.DialogState)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.Unity.Collections
{
    using System;
    using MessagePack;

    public sealed class LayoutTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Collections.LayoutTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Collections.LayoutTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Collections.LayoutTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Collections.LayoutTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class OrientTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Collections.OrientTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Collections.OrientTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Collections.OrientTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Collections.OrientTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SortTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Collections.SortTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Collections.SortTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Collections.SortTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Collections.SortTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class SurfaceTypeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Collections.SurfaceTypeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Collections.SurfaceTypeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Collections.SurfaceTypeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Collections.SurfaceTypeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class BehaviorEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.Unity.Collections.ObjectCollectionDynamic.BehaviorEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.Unity.Collections.ObjectCollectionDynamic.BehaviorEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.Unity.Collections.ObjectCollectionDynamic.BehaviorEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.Unity.Collections.ObjectCollectionDynamic.BehaviorEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.UX.Progress
{
    using System;
    using MessagePack;

    public sealed class IndicatorStyleEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.Progress.IndicatorStyleEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.Progress.IndicatorStyleEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.Progress.IndicatorStyleEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.Progress.IndicatorStyleEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ProgressMessageStyleEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.Progress.ProgressMessageStyleEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.Progress.ProgressMessageStyleEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.Progress.ProgressMessageStyleEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.Progress.ProgressMessageStyleEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ProgressStyleEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.Progress.ProgressStyleEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.Progress.ProgressStyleEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.Progress.ProgressStyleEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.Progress.ProgressStyleEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.HoloToolkit.UX.ToolTips
{
    using System;
    using MessagePack;

    public sealed class ToolTipAttachPointTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ToolTipAttachPointType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ToolTipAttachPointType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ToolTipAttachPointType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ToolTipAttachPointType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ConnectorFollowTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ConnectorFollowType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ConnectorFollowType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ConnectorFollowType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ConnectorFollowType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ConnectorOrientTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ConnectorOrientType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ConnectorOrientType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ConnectorOrientType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ConnectorOrientType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ConnnectorPivotModeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ConnnectorPivotMode>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ConnnectorPivotMode value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ConnnectorPivotMode Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ConnnectorPivotMode)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class ConnectorPivotDirectionFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ConnectorPivotDirection>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ConnectorPivotDirection value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ConnectorPivotDirection Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ConnectorPivotDirection)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class TipDisplayModeEnumFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.TipDisplayModeEnum>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.TipDisplayModeEnum value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.TipDisplayModeEnum Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.TipDisplayModeEnum)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }

    public sealed class RemainTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::HoloToolkit.UX.ToolTips.ToolTipSpawner.RemainType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::HoloToolkit.UX.ToolTips.ToolTipSpawner.RemainType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteInt32(ref bytes, offset, (Int32)value);
        }
        
        public global::HoloToolkit.UX.ToolTips.ToolTipSpawner.RemainType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::HoloToolkit.UX.ToolTips.ToolTipSpawner.RemainType)MessagePackBinary.ReadInt32(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters.MessagePack
{
    using System;
    using MessagePack;

    public sealed class MessagePackTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MessagePack.MessagePackType>
    {
        public int Serialize(ref byte[] bytes, int offset, global::MessagePack.MessagePackType value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            return MessagePackBinary.WriteByte(ref bytes, offset, (Byte)value);
        }
        
        public global::MessagePack.MessagePackType Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            return (global::MessagePack.MessagePackType)MessagePackBinary.ReadByte(bytes, offset, out readSize);
        }
    }


}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612


#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace MessagePack.Formatters
{
    using System;
    using MessagePack;


    public sealed class MyClassFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MyClass>
    {

        public int Serialize(ref byte[] bytes, int offset, global::MyClass value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 3);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.Age);
            offset += formatterResolver.GetFormatterWithVerify<string>().Serialize(ref bytes, offset, value.FirstName, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<string>().Serialize(ref bytes, offset, value.LastName, formatterResolver);
            return offset - startOffset;
        }

        public global::MyClass Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Age__ = default(int);
            var __FirstName__ = default(string);
            var __LastName__ = default(string);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __Age__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __FirstName__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __LastName__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::MyClass();
            ____result.Age = __Age__;
            ____result.FirstName = __FirstName__;
            ____result.LastName = __LastName__;
            return ____result;
        }
    }


    public sealed class MyTransformFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MyTransform>
    {

        public int Serialize(ref byte[] bytes, int offset, global::MyTransform value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 4);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Serialize(ref bytes, offset, value.Pos, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Quaternion>().Serialize(ref bytes, offset, value.Rot, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Serialize(ref bytes, offset, value.Scale, formatterResolver);
            offset += MessagePackBinary.WriteSingle(ref bytes, offset, value.Time);
            return offset - startOffset;
        }

        public global::MyTransform Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __Pos__ = default(global::UnityEngine.Vector3);
            var __Rot__ = default(global::UnityEngine.Quaternion);
            var __Scale__ = default(global::UnityEngine.Vector3);
            var __Time__ = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __Pos__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 1:
                        __Rot__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Quaternion>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __Scale__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 3:
                        __Time__ = MessagePackBinary.ReadSingle(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::MyTransform();
            ____result.Pos = __Pos__;
            ____result.Rot = __Rot__;
            ____result.Scale = __Scale__;
            ____result.Time = __Time__;
            return ____result;
        }
    }


    public sealed class MsgPackSendFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MsgPackSend>
    {

        public int Serialize(ref byte[] bytes, int offset, global::MsgPackSend value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 5);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += formatterResolver.GetFormatterWithVerify<global::MyTransform[]>().Serialize(ref bytes, offset, value.array, formatterResolver);
            return offset - startOffset;
        }

        public global::MsgPackSend Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __array__ = default(global::MyTransform[]);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 4:
                        __array__ = formatterResolver.GetFormatterWithVerify<global::MyTransform[]>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::MsgPackSend();
            ____result.array = __array__;
            return ____result;
        }
    }


    public sealed class MultiTransformFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MultiTransform>
    {

        public int Serialize(ref byte[] bytes, int offset, global::MultiTransform value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 7);
            offset += MessagePackBinary.WriteInt32(ref bytes, offset, value.ID);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Serialize(ref bytes, offset, value.Pos, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Quaternion>().Serialize(ref bytes, offset, value.Rot, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Serialize(ref bytes, offset, value.Scale, formatterResolver);
            offset += MessagePackBinary.WriteSingle(ref bytes, offset, value.Time);
            offset += formatterResolver.GetFormatterWithVerify<global::EVENT_TYPE>().Serialize(ref bytes, offset, value.Type, formatterResolver);
            offset += formatterResolver.GetFormatterWithVerify<string>().Serialize(ref bytes, offset, value.EventString, formatterResolver);
            return offset - startOffset;
        }

        public global::MultiTransform Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __ID__ = default(int);
            var __Type__ = default(global::EVENT_TYPE);
            var __EventString__ = default(string);
            var __Pos__ = default(global::UnityEngine.Vector3);
            var __Rot__ = default(global::UnityEngine.Quaternion);
            var __Scale__ = default(global::UnityEngine.Vector3);
            var __Time__ = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __ID__ = MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 5:
                        __Type__ = formatterResolver.GetFormatterWithVerify<global::EVENT_TYPE>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 6:
                        __EventString__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 1:
                        __Pos__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 2:
                        __Rot__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Quaternion>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 3:
                        __Scale__ = formatterResolver.GetFormatterWithVerify<global::UnityEngine.Vector3>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    case 4:
                        __Time__ = MessagePackBinary.ReadSingle(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::MultiTransform();
            ____result.ID = __ID__;
            ____result.Type = __Type__;
            ____result.EventString = __EventString__;
            ____result.Pos = __Pos__;
            ____result.Rot = __Rot__;
            ____result.Scale = __Scale__;
            ____result.Time = __Time__;
            return ____result;
        }
    }


    public sealed class MsgPackMultiTransformSendFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MsgPackMultiTransformSend>
    {

        public int Serialize(ref byte[] bytes, int offset, global::MsgPackMultiTransformSend value, global::MessagePack.IFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                return global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            }
            
            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 8);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += global::MessagePack.MessagePackBinary.WriteNil(ref bytes, offset);
            offset += formatterResolver.GetFormatterWithVerify<global::MultiTransform[]>().Serialize(ref bytes, offset, value.array, formatterResolver);
            return offset - startOffset;
        }

        public global::MsgPackMultiTransformSend Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                readSize = 1;
                return null;
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __array__ = default(global::MultiTransform[]);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 7:
                        __array__ = formatterResolver.GetFormatterWithVerify<global::MultiTransform[]>().Deserialize(bytes, offset, formatterResolver, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::MsgPackMultiTransformSend();
            ____result.array = __array__;
            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
