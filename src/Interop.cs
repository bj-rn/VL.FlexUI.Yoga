using System;
using System.Runtime.InteropServices;

namespace VL.FlexUI.Yoga
{
    public class Yoga
    {

        const string YogaDll = "yogacore.dll";


        #region YGConfig

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern IntPtr YGConfigNew();
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGConfigFree(IntPtr config);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern IntPtr YGConfigGetDefault();

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGConfigSetPointScaleFactor(IntPtr config, float enabled);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGConfigSetErrata(IntPtr config, Errata errata);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGConfigSetExperimentalFeatureEnabled(IntPtr config, ExperimentalFeature feature, bool enabled);

        #endregion

        #region YGNode

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern IntPtr YGNodeNew();
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeFree(IntPtr node);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, Direction ownerDirection);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeInsertChild(IntPtr node, IntPtr child, int index);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeRemoveChild(IntPtr node, IntPtr child);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeRemoveAllChildren(IntPtr node);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeSetConfig(IntPtr node, IntPtr config);

        #endregion

        #region YGNodeLayout

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern float YGNodeLayoutGetLeft(IntPtr node);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern float YGNodeLayoutGetTop(IntPtr node);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern float YGNodeLayoutGetWidth(IntPtr node);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern float YGNodeLayoutGetHeight(IntPtr node);

        #endregion

        #region YGNodeStyle

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetDirection(IntPtr node, Direction direction);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexDirection(IntPtr node, FlexDirection flexDirection);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetJustifyContent(IntPtr node, Justify justifyContent);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetAlignContent(IntPtr node, Align alignContent);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetAlignItems(IntPtr node, Align alignItems);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetAlignSelf(IntPtr node, Align alignSelf);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetPositionType(IntPtr node, PositionType positionType);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexWrap(IntPtr node, Wrap flexWrap);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetFlexBasisAuto(IntPtr node);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetPosition(IntPtr node, Edge edge, float position);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetPositionPercent(IntPtr node, Edge edge, float position);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMargin(IntPtr node, Edge edge, float margin);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMarginPercent(IntPtr node, Edge edge, float margin);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMarginAuto(IntPtr node, Edge edge);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetPadding(IntPtr node, Edge edge, float padding);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetPaddingPercent(IntPtr node, Edge edge, float padding);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetGap(IntPtr node, Gutter gutter, float gapLength);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetWidth(IntPtr node, float width);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetWidthPercent(IntPtr node, float width);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetWidthAuto(IntPtr node);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetHeight(IntPtr node, float height);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetHeightPercent(IntPtr node, float height);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetHeightAuto(IntPtr node);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMinWidth(IntPtr node, float minWidth);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMinHeight(IntPtr node, float minHeight);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight);
        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight);

        [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)] public static extern void YGNodeStyleSetAspectRatio(IntPtr node, float aspectRatio);

        #endregion
    }
}
