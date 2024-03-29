// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System.Collections.Generic;
using System.Text;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    [System.CodeDom.Compiler.GeneratedCode("Magick.NET.FileGenerator", "")]
    public sealed partial class Drawables
    {
        /// <summary>
        /// Applies the DrawableAffine operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="scaleX">The X coordinate scaling element.</param>
        /// <param name="scaleY">The Y coordinate scaling element.</param>
        /// <param name="shearX">The X coordinate shearing element.</param>
        /// <param name="shearY">The Y coordinate shearing element.</param>
        /// <param name="translateX">The X coordinate of the translation element.</param>
        /// <param name="translateY">The Y coordinate of the translation element.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Affine(double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY)
        {
            _drawables.Add(new DrawableAffine(scaleX, scaleY, shearX, shearY, translateX, translateY));
            return this;
        }

        /// <summary>
        /// Applies the DrawableAlpha operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Alpha(double x, double y, PaintMethod paintMethod)
        {
            _drawables.Add(new DrawableAlpha(x, y, paintMethod));
            return this;
        }

        /// <summary>
        /// Applies the DrawableArc operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate of the bounding rectangle.</param>
        /// <param name="startY">The starting Y coordinate of thebounding rectangle.</param>
        /// <param name="endX">The ending X coordinate of the bounding rectangle.</param>
        /// <param name="endY">The ending Y coordinate of the bounding rectangle.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Arc(double startX, double startY, double endX, double endY, double startDegrees, double endDegrees)
        {
            _drawables.Add(new DrawableArc(startX, startY, endX, endY, startDegrees, endDegrees));
            return this;
        }

        /// <summary>
        /// Applies the DrawableBezier operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Bezier(params PointD[] coordinates)
        {
            _drawables.Add(new DrawableBezier(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawableBezier operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Bezier(IEnumerable<PointD> coordinates)
        {
            _drawables.Add(new DrawableBezier(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawableBorderColor operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color of the border.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> BorderColor(IMagickColor<QuantumType> color)
        {
            _drawables.Add(new DrawableBorderColor(color));
            return this;
        }

        /// <summary>
        /// Applies the DrawableCircle operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="perimeterX">The perimeter X coordinate.</param>
        /// <param name="perimeterY">The perimeter Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Circle(double originX, double originY, double perimeterX, double perimeterY)
        {
            _drawables.Add(new DrawableCircle(originX, originY, perimeterX, perimeterY));
            return this;
        }

        /// <summary>
        /// Applies the DrawableClipPath operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> ClipPath(string clipPath)
        {
            _drawables.Add(new DrawableClipPath(clipPath));
            return this;
        }

        /// <summary>
        /// Applies the DrawableClipRule operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> ClipRule(FillRule fillRule)
        {
            _drawables.Add(new DrawableClipRule(fillRule));
            return this;
        }

        /// <summary>
        /// Applies the DrawableClipUnits operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="units">The clip path units.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> ClipUnits(ClipPathUnit units)
        {
            _drawables.Add(new DrawableClipUnits(units));
            return this;
        }

        /// <summary>
        /// Applies the DrawableColor operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Color(double x, double y, PaintMethod paintMethod)
        {
            _drawables.Add(new DrawableColor(x, y, paintMethod));
            return this;
        }

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Composite(IMagickGeometry offset, IMagickImage<QuantumType> image)
        {
            _drawables.Add(new DrawableComposite(offset, image));
            return this;
        }

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Composite(double x, double y, IMagickImage<QuantumType> image)
        {
            _drawables.Add(new DrawableComposite(x, y, image));
            return this;
        }

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Composite(IMagickGeometry offset, CompositeOperator compose, IMagickImage<QuantumType> image)
        {
            _drawables.Add(new DrawableComposite(offset, compose, image));
            return this;
        }

        /// <summary>
        /// Applies the DrawableComposite operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Composite(double x, double y, CompositeOperator compose, IMagickImage<QuantumType> image)
        {
            _drawables.Add(new DrawableComposite(x, y, compose, image));
            return this;
        }

        /// <summary>
        /// Applies the DrawableDensity operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="density">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Density(double density)
        {
            _drawables.Add(new DrawableDensity(density));
            return this;
        }

        /// <summary>
        /// Applies the DrawableDensity operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="pointDensity">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Density(PointD pointDensity)
        {
            _drawables.Add(new DrawableDensity(pointDensity));
            return this;
        }

        /// <summary>
        /// Applies the DrawableEllipse operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="radiusX">The X radius.</param>
        /// <param name="radiusY">The Y radius.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Ellipse(double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees)
        {
            _drawables.Add(new DrawableEllipse(originX, originY, radiusX, radiusY, startDegrees, endDegrees));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFillColor operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> FillColor(IMagickColor<QuantumType> color)
        {
            _drawables.Add(new DrawableFillColor(color));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFillOpacity operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> FillOpacity(Percentage opacity)
        {
            _drawables.Add(new DrawableFillOpacity(opacity));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFillPatternUrl operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> FillPatternUrl(string url)
        {
            _drawables.Add(new DrawableFillPatternUrl(url));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFillRule operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> FillRule(FillRule fillRule)
        {
            _drawables.Add(new DrawableFillRule(fillRule));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFont operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Font(string family)
        {
            _drawables.Add(new DrawableFont(family));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFont operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <param name="style">The style of the font.</param>
        /// <param name="weight">The weight of the font.</param>
        /// <param name="stretch">The font stretching type.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Font(string family, FontStyleType style, FontWeight weight, FontStretch stretch)
        {
            _drawables.Add(new DrawableFont(family, style, weight, stretch));
            return this;
        }

        /// <summary>
        /// Applies the DrawableFontPointSize operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="pointSize">The point size.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> FontPointSize(double pointSize)
        {
            _drawables.Add(new DrawableFontPointSize(pointSize));
            return this;
        }

        /// <summary>
        /// Applies the DrawableGravity operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="gravity">The gravity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Gravity(Gravity gravity)
        {
            _drawables.Add(new DrawableGravity(gravity));
            return this;
        }

        /// <summary>
        /// Applies the DrawableLine operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate.</param>
        /// <param name="startY">The starting Y coordinate.</param>
        /// <param name="endX">The ending X coordinate.</param>
        /// <param name="endY">The ending Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Line(double startX, double startY, double endX, double endY)
        {
            _drawables.Add(new DrawableLine(startX, startY, endX, endY));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePath operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Path(params IPath[] paths)
        {
            _drawables.Add(new DrawablePath(paths));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePath operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Path(IEnumerable<IPath> paths)
        {
            _drawables.Add(new DrawablePath(paths));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePoint operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Point(double x, double y)
        {
            _drawables.Add(new DrawablePoint(x, y));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePolygon operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Polygon(params PointD[] coordinates)
        {
            _drawables.Add(new DrawablePolygon(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePolygon operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Polygon(IEnumerable<PointD> coordinates)
        {
            _drawables.Add(new DrawablePolygon(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePolyline operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Polyline(params PointD[] coordinates)
        {
            _drawables.Add(new DrawablePolyline(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePolyline operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Polyline(IEnumerable<PointD> coordinates)
        {
            _drawables.Add(new DrawablePolyline(coordinates));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePopClipPath operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PopClipPath()
        {
            _drawables.Add(new DrawablePopClipPath());
            return this;
        }

        /// <summary>
        /// Applies the DrawablePopGraphicContext operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PopGraphicContext()
        {
            _drawables.Add(new DrawablePopGraphicContext());
            return this;
        }

        /// <summary>
        /// Applies the DrawablePopPattern operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PopPattern()
        {
            _drawables.Add(new DrawablePopPattern());
            return this;
        }

        /// <summary>
        /// Applies the DrawablePushClipPath operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PushClipPath(string clipPath)
        {
            _drawables.Add(new DrawablePushClipPath(clipPath));
            return this;
        }

        /// <summary>
        /// Applies the DrawablePushGraphicContext operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PushGraphicContext()
        {
            _drawables.Add(new DrawablePushGraphicContext());
            return this;
        }

        /// <summary>
        /// Applies the DrawablePushPattern operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="id">The ID of the pattern.</param>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> PushPattern(string id, double x, double y, double width, double height)
        {
            _drawables.Add(new DrawablePushPattern(id, x, y, width, height));
            return this;
        }

        /// <summary>
        /// Applies the DrawableRectangle operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Rectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
        {
            _drawables.Add(new DrawableRectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
            return this;
        }

        /// <summary>
        /// Applies the DrawableRotation operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Rotation(double angle)
        {
            _drawables.Add(new DrawableRotation(angle));
            return this;
        }

        /// <summary>
        /// Applies the DrawableRoundRectangle operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <param name="cornerWidth">The corner width.</param>
        /// <param name="cornerHeight">The corner height.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> RoundRectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, double cornerWidth, double cornerHeight)
        {
            _drawables.Add(new DrawableRoundRectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY, cornerWidth, cornerHeight));
            return this;
        }

        /// <summary>
        /// Applies the DrawableScaling operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">Horizontal scale factor.</param>
        /// <param name="y">Vertical scale factor.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Scaling(double x, double y)
        {
            _drawables.Add(new DrawableScaling(x, y));
            return this;
        }

        /// <summary>
        /// Applies the DrawableSkewX operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> SkewX(double angle)
        {
            _drawables.Add(new DrawableSkewX(angle));
            return this;
        }

        /// <summary>
        /// Applies the DrawableSkewY operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> SkewY(double angle)
        {
            _drawables.Add(new DrawableSkewY(angle));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeColor operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeColor(IMagickColor<QuantumType> color)
        {
            _drawables.Add(new DrawableStrokeColor(color));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeDashArray operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="dash">An array containing the dash information.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeDashArray(params double[] dash)
        {
            _drawables.Add(new DrawableStrokeDashArray(dash));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeDashOffset operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The dash offset.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeDashOffset(double offset)
        {
            _drawables.Add(new DrawableStrokeDashOffset(offset));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeLineCap operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="lineCap">The line cap.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeLineCap(LineCap lineCap)
        {
            _drawables.Add(new DrawableStrokeLineCap(lineCap));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeLineJoin operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="lineJoin">The line join.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeLineJoin(LineJoin lineJoin)
        {
            _drawables.Add(new DrawableStrokeLineJoin(lineJoin));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeMiterLimit operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="miterlimit">The miter limit.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeMiterLimit(int miterlimit)
        {
            _drawables.Add(new DrawableStrokeMiterLimit(miterlimit));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeOpacity operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeOpacity(Percentage opacity)
        {
            _drawables.Add(new DrawableStrokeOpacity(opacity));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokePatternUrl operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokePatternUrl(string url)
        {
            _drawables.Add(new DrawableStrokePatternUrl(url));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeWidth operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> StrokeWidth(double width)
        {
            _drawables.Add(new DrawableStrokeWidth(width));
            return this;
        }

        /// <summary>
        /// Applies the DrawableText operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="value">The text to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Text(double x, double y, string value)
        {
            _drawables.Add(new DrawableText(x, y, value));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextAlignment operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="alignment">Text alignment.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextAlignment(TextAlignment alignment)
        {
            _drawables.Add(new DrawableTextAlignment(alignment));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextDecoration operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="decoration">The text decoration.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextDecoration(TextDecoration decoration)
        {
            _drawables.Add(new DrawableTextDecoration(decoration));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextDirection operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="direction">Direction to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextDirection(TextDirection direction)
        {
            _drawables.Add(new DrawableTextDirection(direction));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextEncoding operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="encoding">Encoding to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextEncoding(Encoding encoding)
        {
            _drawables.Add(new DrawableTextEncoding(encoding));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextInterlineSpacing operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextInterlineSpacing(double spacing)
        {
            _drawables.Add(new DrawableTextInterlineSpacing(spacing));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextInterwordSpacing operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextInterwordSpacing(double spacing)
        {
            _drawables.Add(new DrawableTextInterwordSpacing(spacing));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextKerning operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="kerning">Kerning to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextKerning(double kerning)
        {
            _drawables.Add(new DrawableTextKerning(kerning));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextUnderColor operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> TextUnderColor(IMagickColor<QuantumType> color)
        {
            _drawables.Add(new DrawableTextUnderColor(color));
            return this;
        }

        /// <summary>
        /// Applies the DrawableTranslation operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Translation(double x, double y)
        {
            _drawables.Add(new DrawableTranslation(x, y));
            return this;
        }

        /// <summary>
        /// Applies the DrawableViewbox operation to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> Viewbox(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
        {
            _drawables.Add(new DrawableViewbox(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeAntialias operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> DisableStrokeAntialias()
        {
            _drawables.Add(DrawableStrokeAntialias.Disabled);
            return this;
        }

        /// <summary>
        /// Applies the DrawableStrokeAntialias operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> EnableStrokeAntialias()
        {
            _drawables.Add(DrawableStrokeAntialias.Enabled);
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextAntialias operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> DisableTextAntialias()
        {
            _drawables.Add(DrawableTextAntialias.Disabled);
            return this;
        }

        /// <summary>
        /// Applies the DrawableTextAntialias operation to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public IDrawables<QuantumType> EnableTextAntialias()
        {
            _drawables.Add(DrawableTextAntialias.Enabled);
            return this;
        }

    }
}
