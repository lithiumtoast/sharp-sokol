// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

// ReSharper disable MemberCanBeInternal
// ReSharper disable CheckNamespace
// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable ShiftExpressionRealShiftCountIsZero

/// <summary>
///     The structs, enums, and static methods of `sokol_gfx`. Everything in this module exactly matches what is in
///     C, and the naming conventions used in C are maintained. For documentation see the comments in the
///     <a href="https://github.com/floooh/sokol/blob/master/sokol_gfx.h">`sokol_gfx.h` source code</a>.
/// </summary>
/// <remarks>
///     <para>
///         For practicality, it's recommended to import the module like so:
///         <c>using static sokol_gfx;</c>.
///     </para>
/// </remarks>
[SuppressMessage("ReSharper", "SA1204", Justification = "C style code.")]
[SuppressMessage("ReSharper", "SA1300", Justification = "C style code.")]
[SuppressMessage("ReSharper", "SA1307", Justification = "C style code.")]
[SuppressMessage("ReSharper", "SA1310", Justification = "C style code.")]
[SuppressMessage("ReSharper", "SA1600", Justification = "C style code.")]
[SuppressMessage("ReSharper", "SA1602", Justification = "C style code.")]
[SuppressMessage("ReSharper", "CommentTypo", Justification = "C style code.")]
public static unsafe class sokol_gfx
{
    public const int SG_INVALID_ID = 0;
    public const int SG_NUM_SHADER_STAGES = 2;
    public const int SG_NUM_INFLIGHT_FRAMES = 2;
    public const int SG_MAX_COLOR_ATTACHMENTS = 4;
    public const int SG_MAX_SHADERSTAGE_BUFFERS = 8;
    public const int SG_MAX_SHADERSTAGE_IMAGES = 12;
    public const int SG_MAX_SHADERSTAGE_UBS = 4;
    public const int SG_MAX_UB_MEMBERS = 16;
    public const int SG_MAX_VERTEX_ATTRIBUTES = 16;
    public const int SG_MAX_MIPMAPS = 16;
    public const int SG_MAX_TEXTUREARRAY_LAYERS = 128;

    private const string LibraryName = "sokol_gfx";

    public enum sg_backend : uint
    {
        SG_BACKEND_GLCORE33 = 0U,
        SG_BACKEND_GLES2 = 1U,
        SG_BACKEND_GLES3 = 2U,
        SG_BACKEND_D3D11 = 3U,
        SG_BACKEND_METAL_IOS = 4U,
        SG_BACKEND_METAL_MACOS = 5U,
        SG_BACKEND_METAL_SIMULATOR = 6U,
        SG_BACKEND_WGPU = 7U,
        SG_BACKEND_DUMMY = 8U
    }

    public enum sg_pixel_format : uint
    {
        _SG_PIXELFORMAT_DEFAULT = 0U,
        SG_PIXELFORMAT_NONE = 1U,
        SG_PIXELFORMAT_R8 = 2U,
        SG_PIXELFORMAT_R8SN = 3U,
        SG_PIXELFORMAT_R8UI = 4U,
        SG_PIXELFORMAT_R8SI = 5U,
        SG_PIXELFORMAT_R16 = 6U,
        SG_PIXELFORMAT_R16SN = 7U,
        SG_PIXELFORMAT_R16UI = 8U,
        SG_PIXELFORMAT_R16SI = 9U,
        SG_PIXELFORMAT_R16F = 10U,
        SG_PIXELFORMAT_RG8 = 11U,
        SG_PIXELFORMAT_RG8SN = 12U,
        SG_PIXELFORMAT_RG8UI = 13U,
        SG_PIXELFORMAT_RG8SI = 14U,
        SG_PIXELFORMAT_R32UI = 15U,
        SG_PIXELFORMAT_R32SI = 16U,
        SG_PIXELFORMAT_R32F = 17U,
        SG_PIXELFORMAT_RG16 = 18U,
        SG_PIXELFORMAT_RG16SN = 19U,
        SG_PIXELFORMAT_RG16UI = 20U,
        SG_PIXELFORMAT_RG16SI = 21U,
        SG_PIXELFORMAT_RG16F = 22U,
        SG_PIXELFORMAT_RGBA8 = 23U,
        SG_PIXELFORMAT_RGBA8SN = 24U,
        SG_PIXELFORMAT_RGBA8UI = 25U,
        SG_PIXELFORMAT_RGBA8SI = 26U,
        SG_PIXELFORMAT_BGRA8 = 27U,
        SG_PIXELFORMAT_RGB10A2 = 28U,
        SG_PIXELFORMAT_RG11B10F = 29U,
        SG_PIXELFORMAT_RG32UI = 30U,
        SG_PIXELFORMAT_RG32SI = 31U,
        SG_PIXELFORMAT_RG32F = 32U,
        SG_PIXELFORMAT_RGBA16 = 33U,
        SG_PIXELFORMAT_RGBA16SN = 34U,
        SG_PIXELFORMAT_RGBA16UI = 35U,
        SG_PIXELFORMAT_RGBA16SI = 36U,
        SG_PIXELFORMAT_RGBA16F = 37U,
        SG_PIXELFORMAT_RGBA32UI = 38U,
        SG_PIXELFORMAT_RGBA32SI = 39U,
        SG_PIXELFORMAT_RGBA32F = 40U,
        SG_PIXELFORMAT_DEPTH = 41U,
        SG_PIXELFORMAT_DEPTH_STENCIL = 42U,
        SG_PIXELFORMAT_BC1_RGBA = 43U,
        SG_PIXELFORMAT_BC2_RGBA = 44U,
        SG_PIXELFORMAT_BC3_RGBA = 45U,
        SG_PIXELFORMAT_BC4_R = 46U,
        SG_PIXELFORMAT_BC4_RSN = 47U,
        SG_PIXELFORMAT_BC5_RG = 48U,
        SG_PIXELFORMAT_BC5_RGSN = 49U,
        SG_PIXELFORMAT_BC6H_RGBF = 50U,
        SG_PIXELFORMAT_BC6H_RGBUF = 51U,
        SG_PIXELFORMAT_BC7_RGBA = 52U,
        SG_PIXELFORMAT_PVRTC_RGB_2BPP = 53U,
        SG_PIXELFORMAT_PVRTC_RGB_4BPP = 54U,
        SG_PIXELFORMAT_PVRTC_RGBA_2BPP = 55U,
        SG_PIXELFORMAT_PVRTC_RGBA_4BPP = 56U,
        SG_PIXELFORMAT_ETC2_RGB8 = 57U,
        SG_PIXELFORMAT_ETC2_RGB8A1 = 58U,
        SG_PIXELFORMAT_ETC2_RGBA8 = 59U,
        SG_PIXELFORMAT_ETC2_RG11 = 60U,
        SG_PIXELFORMAT_ETC2_RG11SN = 61U,
        _SG_PIXELFORMAT_NUM = 62U,
        _SG_PIXELFORMAT_FORCE_U32 = 2147483647U
    }

    public enum sg_resource_state : uint
    {
        SG_RESOURCESTATE_INITIAL = 0U,
        SG_RESOURCESTATE_ALLOC = 1U,
        SG_RESOURCESTATE_VALID = 2U,
        SG_RESOURCESTATE_FAILED = 3U,
        SG_RESOURCESTATE_INVALID = 4U,
        _SG_RESOURCESTATE_FORCE_U32 = 2147483647U
    }

    public enum sg_usage : uint
    {
        _SG_USAGE_DEFAULT = 0U,
        SG_USAGE_IMMUTABLE = 1U,
        SG_USAGE_DYNAMIC = 2U,
        SG_USAGE_STREAM = 3U,
        _SG_USAGE_NUM = 4U,
        _SG_USAGE_FORCE_U32 = 2147483647U
    }

    public enum sg_buffer_type : uint
    {
        _SG_BUFFERTYPE_DEFAULT = 0U,
        SG_BUFFERTYPE_VERTEXBUFFER = 1U,
        SG_BUFFERTYPE_INDEXBUFFER = 2U,
        _SG_BUFFERTYPE_NUM = 3U,
        _SG_BUFFERTYPE_FORCE_U32 = 2147483647U
    }

    public enum sg_index_type : uint
    {
        _SG_INDEXTYPE_DEFAULT = 0U,
        SG_INDEXTYPE_NONE = 1U,
        SG_INDEXTYPE_UINT16 = 2U,
        SG_INDEXTYPE_UINT32 = 3U,
        _SG_INDEXTYPE_NUM = 4U,
        _SG_INDEXTYPE_FORCE_U32 = 2147483647U
    }

    public enum sg_image_type : uint
    {
        _SG_IMAGETYPE_DEFAULT = 0U,
        SG_IMAGETYPE_2D = 1U,
        SG_IMAGETYPE_CUBE = 2U,
        SG_IMAGETYPE_3D = 3U,
        SG_IMAGETYPE_ARRAY = 4U,
        _SG_IMAGETYPE_NUM = 5U,
        _SG_IMAGETYPE_FORCE_U32 = 2147483647U
    }

    public enum sg_sampler_type : uint
    {
        _SG_SAMPLERTYPE_DEFAULT = 0U,
        SG_SAMPLERTYPE_FLOAT = 1U,
        SG_SAMPLERTYPE_SINT = 2U,
        SG_SAMPLERTYPE_UINT = 3U
    }

    public enum sg_cube_face : uint
    {
        SG_CUBEFACE_POS_X = 0U,
        SG_CUBEFACE_NEG_X = 1U,
        SG_CUBEFACE_POS_Y = 2U,
        SG_CUBEFACE_NEG_Y = 3U,
        SG_CUBEFACE_POS_Z = 4U,
        SG_CUBEFACE_NEG_Z = 5U,
        SG_CUBEFACE_NUM = 6U,
        _SG_CUBEFACE_FORCE_U32 = 2147483647U
    }

    public enum sg_shader_stage : uint
    {
        SG_SHADERSTAGE_VS = 0U,
        SG_SHADERSTAGE_FS = 1U,
        _SG_SHADERSTAGE_FORCE_U32 = 2147483647U
    }

    public enum sg_primitive_type : uint
    {
        _SG_PRIMITIVETYPE_DEFAULT = 0U,
        SG_PRIMITIVETYPE_POINTS = 1U,
        SG_PRIMITIVETYPE_LINES = 2U,
        SG_PRIMITIVETYPE_LINE_STRIP = 3U,
        SG_PRIMITIVETYPE_TRIANGLES = 4U,
        SG_PRIMITIVETYPE_TRIANGLE_STRIP = 5U,
        _SG_PRIMITIVETYPE_NUM = 6U,
        _SG_PRIMITIVETYPE_FORCE_U32 = 2147483647U
    }

    public enum sg_filter : uint
    {
        _SG_FILTER_DEFAULT = 0U,
        SG_FILTER_NEAREST = 1U,
        SG_FILTER_LINEAR = 2U,
        SG_FILTER_NEAREST_MIPMAP_NEAREST = 3U,
        SG_FILTER_NEAREST_MIPMAP_LINEAR = 4U,
        SG_FILTER_LINEAR_MIPMAP_NEAREST = 5U,
        SG_FILTER_LINEAR_MIPMAP_LINEAR = 6U,
        _SG_FILTER_NUM = 7U,
        _SG_FILTER_FORCE_U32 = 2147483647U
    }

    public enum sg_wrap : uint
    {
        _SG_WRAP_DEFAULT = 0U,
        SG_WRAP_REPEAT = 1U,
        SG_WRAP_CLAMP_TO_EDGE = 2U,
        SG_WRAP_CLAMP_TO_BORDER = 3U,
        SG_WRAP_MIRRORED_REPEAT = 4U,
        _SG_WRAP_NUM = 5U,
        _SG_WRAP_FORCE_U32 = 2147483647U
    }

    public enum sg_border_color : uint
    {
        _SG_BORDERCOLOR_DEFAULT = 0U,
        SG_BORDERCOLOR_TRANSPARENT_BLACK = 1U,
        SG_BORDERCOLOR_OPAQUE_BLACK = 2U,
        SG_BORDERCOLOR_OPAQUE_WHITE = 3U,
        _SG_BORDERCOLOR_NUM = 4U,
        _SG_BORDERCOLOR_FORCE_U32 = 2147483647U
    }

    public enum sg_vertex_format : uint
    {
        SG_VERTEXFORMAT_INVALID = 0U,
        SG_VERTEXFORMAT_FLOAT = 1U,
        SG_VERTEXFORMAT_FLOAT2 = 2U,
        SG_VERTEXFORMAT_FLOAT3 = 3U,
        SG_VERTEXFORMAT_FLOAT4 = 4U,
        SG_VERTEXFORMAT_BYTE4 = 5U,
        SG_VERTEXFORMAT_BYTE4N = 6U,
        SG_VERTEXFORMAT_UBYTE4 = 7U,
        SG_VERTEXFORMAT_UBYTE4N = 8U,
        SG_VERTEXFORMAT_SHORT2 = 9U,
        SG_VERTEXFORMAT_SHORT2N = 10U,
        SG_VERTEXFORMAT_USHORT2N = 11U,
        SG_VERTEXFORMAT_SHORT4 = 12U,
        SG_VERTEXFORMAT_SHORT4N = 13U,
        SG_VERTEXFORMAT_USHORT4N = 14U,
        SG_VERTEXFORMAT_UINT10_N2 = 15U,
        _SG_VERTEXFORMAT_NUM = 16U,
        _SG_VERTEXFORMAT_FORCE_U32 = 2147483647U
    }

    public enum sg_vertex_step : uint
    {
        _SG_VERTEXSTEP_DEFAULT = 0U,
        SG_VERTEXSTEP_PER_VERTEX = 1U,
        SG_VERTEXSTEP_PER_INSTANCE = 2U,
        _SG_VERTEXSTEP_NUM = 3U,
        _SG_VERTEXSTEP_FORCE_U32 = 2147483647U
    }

    public enum sg_uniform_type : uint
    {
        SG_UNIFORMTYPE_INVALID = 0U,
        SG_UNIFORMTYPE_FLOAT = 1U,
        SG_UNIFORMTYPE_FLOAT2 = 2U,
        SG_UNIFORMTYPE_FLOAT3 = 3U,
        SG_UNIFORMTYPE_FLOAT4 = 4U,
        SG_UNIFORMTYPE_MAT4 = 5U,
        _SG_UNIFORMTYPE_NUM = 6U,
        _SG_UNIFORMTYPE_FORCE_U32 = 2147483647U
    }

    public enum sg_cull_mode : uint
    {
        _SG_CULLMODE_DEFAULT = 0U,
        SG_CULLMODE_NONE = 1U,
        SG_CULLMODE_FRONT = 2U,
        SG_CULLMODE_BACK = 3U,
        _SG_CULLMODE_NUM = 4U,
        _SG_CULLMODE_FORCE_U32 = 2147483647U
    }

    public enum sg_face_winding : uint
    {
        _SG_FACEWINDING_DEFAULT = 0U,
        SG_FACEWINDING_CCW = 1U,
        SG_FACEWINDING_CW = 2U,
        _SG_FACEWINDING_NUM = 3U,
        _SG_FACEWINDING_FORCE_U32 = 2147483647U
    }

    public enum sg_compare_func : uint
    {
        _SG_COMPAREFUNC_DEFAULT = 0U,
        SG_COMPAREFUNC_NEVER = 1U,
        SG_COMPAREFUNC_LESS = 2U,
        SG_COMPAREFUNC_EQUAL = 3U,
        SG_COMPAREFUNC_LESS_EQUAL = 4U,
        SG_COMPAREFUNC_GREATER = 5U,
        SG_COMPAREFUNC_NOT_EQUAL = 6U,
        SG_COMPAREFUNC_GREATER_EQUAL = 7U,
        SG_COMPAREFUNC_ALWAYS = 8U,
        _SG_COMPAREFUNC_NUM = 9U,
        _SG_COMPAREFUNC_FORCE_U32 = 2147483647U
    }

    public enum sg_stencil_op : uint
    {
        _SG_STENCILOP_DEFAULT = 0U,
        SG_STENCILOP_KEEP = 1U,
        SG_STENCILOP_ZERO = 2U,
        SG_STENCILOP_REPLACE = 3U,
        SG_STENCILOP_INCR_CLAMP = 4U,
        SG_STENCILOP_DECR_CLAMP = 5U,
        SG_STENCILOP_INVERT = 6U,
        SG_STENCILOP_INCR_WRAP = 7U,
        SG_STENCILOP_DECR_WRAP = 8U,
        _SG_STENCILOP_NUM = 9U,
        _SG_STENCILOP_FORCE_U32 = 2147483647U
    }

    public enum sg_blend_factor : uint
    {
        _SG_BLENDFACTOR_DEFAULT = 0U,
        SG_BLENDFACTOR_ZERO = 1U,
        SG_BLENDFACTOR_ONE = 2U,
        SG_BLENDFACTOR_SRC_COLOR = 3U,
        SG_BLENDFACTOR_ONE_MINUS_SRC_COLOR = 4U,
        SG_BLENDFACTOR_SRC_ALPHA = 5U,
        SG_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = 6U,
        SG_BLENDFACTOR_DST_COLOR = 7U,
        SG_BLENDFACTOR_ONE_MINUS_DST_COLOR = 8U,
        SG_BLENDFACTOR_DST_ALPHA = 9U,
        SG_BLENDFACTOR_ONE_MINUS_DST_ALPHA = 10U,
        SG_BLENDFACTOR_SRC_ALPHA_SATURATED = 11U,
        SG_BLENDFACTOR_BLEND_COLOR = 12U,
        SG_BLENDFACTOR_ONE_MINUS_BLEND_COLOR = 13U,
        SG_BLENDFACTOR_BLEND_ALPHA = 14U,
        SG_BLENDFACTOR_ONE_MINUS_BLEND_ALPHA = 15U,
        _SG_BLENDFACTOR_NUM = 16U,
        _SG_BLENDFACTOR_FORCE_U32 = 2147483647U
    }

    public enum sg_blend_op : uint
    {
        _SG_BLENDOP_DEFAULT = 0U,
        SG_BLENDOP_ADD = 1U,
        SG_BLENDOP_SUBTRACT = 2U,
        SG_BLENDOP_REVERSE_SUBTRACT = 3U,
        _SG_BLENDOP_NUM = 4U,
        _SG_BLENDOP_FORCE_U32 = 2147483647U
    }

    public enum sg_color_mask : uint
    {
        _SG_COLORMASK_DEFAULT = 0U,
        SG_COLORMASK_NONE = 16U,
        SG_COLORMASK_R = 1U,
        SG_COLORMASK_G = 2U,
        SG_COLORMASK_B = 4U,
        SG_COLORMASK_A = 8U,
        SG_COLORMASK_RGB = 7U,
        SG_COLORMASK_RGBA = 15U,
        _SG_COLORMASK_FORCE_U32 = 2147483647U
    }

    public enum sg_action : uint
    {
        _SG_ACTION_DEFAULT = 0U,
        SG_ACTION_CLEAR = 1U,
        SG_ACTION_LOAD = 2U,
        SG_ACTION_DONTCARE = 3U,
        _SG_ACTION_NUM = 4U,
        _SG_ACTION_FORCE_U32 = 2147483647U
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_buffer
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_image
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_shader
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_pipeline
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_pass
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct sg_context
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 6, Pack = 1)]
    public struct sg_pixelformat_info
    {
        [FieldOffset(0)] /* size = 1, padding = 0 */
        public BlittableBoolean sample;

        [FieldOffset(1)] /* size = 1, padding = 0 */
        public BlittableBoolean filter;

        [FieldOffset(2)] /* size = 1, padding = 0 */
        public BlittableBoolean render;

        [FieldOffset(3)] /* size = 1, padding = 0 */
        public BlittableBoolean blend;

        [FieldOffset(4)] /* size = 1, padding = 0 */
        public BlittableBoolean msaa;

        [FieldOffset(5)] /* size = 1, padding = 0 */
        public BlittableBoolean depth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 7, Pack = 1)]
    public struct sg_features
    {
        [FieldOffset(0)] /* size = 1, padding = 0 */
        public BlittableBoolean instancing;

        [FieldOffset(1)] /* size = 1, padding = 0 */
        public BlittableBoolean origin_top_left;

        [FieldOffset(2)] /* size = 1, padding = 0 */
        public BlittableBoolean multiple_render_targets;

        [FieldOffset(3)] /* size = 1, padding = 0 */
        public BlittableBoolean msaa_render_targets;

        [FieldOffset(4)] /* size = 1, padding = 0 */
        public BlittableBoolean imagetype_3d;

        [FieldOffset(5)] /* size = 1, padding = 0 */
        public BlittableBoolean imagetype_array;

        [FieldOffset(6)] /* size = 1, padding = 0 */
        public BlittableBoolean image_clamp_to_border;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
    public struct sg_limits
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint max_image_size_2d;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public uint max_image_size_cube;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public uint max_image_size_3d;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public uint max_image_size_array;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public uint max_image_array_layers;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public uint max_vertex_attrs;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20, Pack = 4)]
    public struct sg_color_attachment_action
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_action action;

        [FieldOffset(4)] /* size = 16, padding = 0 */
        public fixed float val[4]; /* original type is `float [4]` */
    }

    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
    public struct sg_depth_attachment_action
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_action action;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public float val;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
    public struct sg_stencil_attachment_action
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_action action;

        [FieldOffset(4)] /* size = 1, padding = 3 */
        public byte val;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104, Pack = 4)]
    public struct sg_pass_action
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 80, padding = 0 */
        public fixed uint _colors[80 / 4]; /* original type is `sg_color_attachment_action [4]` */

        [FieldOffset(84)] /* size = 8, padding = 0 */
        public sg_depth_attachment_action depth;

        [FieldOffset(92)] /* size = 8, padding = 0 */
        public sg_stencil_attachment_action stencil;

        [FieldOffset(100)] /* size = 4, padding = 0 */
        public uint _end_canary;

        public readonly ref sg_color_attachment_action color(int index = 0)
        {
            fixed (sg_pass_action* @this = &this)
            {
                var pointer = (sg_color_attachment_action*)&@this->_colors[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 176, Pack = 4)]
    public struct sg_bindings
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 32, padding = 0 */
        public fixed uint _vertex_buffers[32 / 4]; /* original type is `sg_buffer [8]` */

        [FieldOffset(36)] /* size = 32, padding = 0 */
        public fixed int vertex_buffer_offsets[8]; /* original type is `int [8]` */

        [FieldOffset(68)] /* size = 4, padding = 0 */
        public sg_buffer index_buffer;

        [FieldOffset(72)] /* size = 4, padding = 0 */
        public int index_buffer_offset;

        [FieldOffset(76)] /* size = 48, padding = 0 */
        public fixed uint _vs_images[48 / 4]; /* original type is `sg_image [12]` */

        [FieldOffset(124)] /* size = 48, padding = 0 */
        public fixed uint _fs_images[48 / 4]; /* original type is `sg_image [12]` */

        [FieldOffset(172)] /* size = 4, padding = 0 */
        public uint _end_canary;

        public readonly ref sg_buffer vertex_buffer(int index = 0)
        {
            fixed (sg_bindings* @this = &this)
            {
                var pointer = (sg_buffer*)&@this->_vertex_buffers[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }

        public readonly ref sg_image vs_image(int index = 0)
        {
            fixed (sg_bindings* @this = &this)
            {
                var pointer = (sg_image*)&@this->_vs_images[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }

        public readonly ref sg_image fs_image(int index = 0)
        {
            fixed (sg_bindings* @this = &this)
            {
                var pointer = (sg_image*)&@this->_fs_images[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 80, Pack = 8)]
    public struct sg_buffer_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public int size;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_buffer_type type;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public sg_usage usage;

        [FieldOffset(16)] /* size = 8, padding = 0 */
        public void* content;

        [FieldOffset(24)] /* size = 8, padding = 0 */
        public byte* label;

        [FieldOffset(32)] /* size = 8, padding = 0 */
        public fixed uint gl_buffers[2]; /* original type is `uint32_t [2]` */

        [FieldOffset(40)] /* size = 16, padding = 0 */
        public fixed ulong _mtl_buffers[16 / 8]; /* original type is `const void *[2]` */

        [FieldOffset(56)] /* size = 8, padding = 0 */
        public void* d3d11_buffer;

        [FieldOffset(64)] /* size = 8, padding = 0 */
        public void* wgpu_buffer;

        [FieldOffset(72)] /* size = 4, padding = 4 */
        public uint _end_canary;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct sg_subimage_content
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public void* ptr;

        [FieldOffset(8)] /* size = 4, padding = 4 */
        public int size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1536, Pack = 8)]
    public struct sg_image_content
    {
        [FieldOffset(0)] /* size = 1536, padding = 0 */
        public fixed ulong _subimage[1536 / 8]; /* original type is `sg_subimage_content [6][16]` */

        public readonly ref sg_subimage_content subimage(sg_cube_face cubeFaceIndex, int mipMapIndex)
        {
            fixed (sg_image_content* image_content = &this)
            {
                var ptr = (sg_subimage_content*)&image_content->_subimage[0];
                var pointerOffset = ((int)cubeFaceIndex * (int)sg_cube_face.SG_CUBEFACE_NUM) + mipMapIndex;
                return ref *(ptr + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 1672, Pack = 8)]
    public struct sg_image_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_image_type type;

        [FieldOffset(8)] /* size = 1, padding = 3 */
        public BlittableBoolean render_target;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public int width;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public int height;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public int depth;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public int layers;

        [FieldOffset(24)] /* size = 4, padding = 0 */
        public int num_mipmaps;

        [FieldOffset(28)] /* size = 4, padding = 0 */
        public sg_usage usage;

        [FieldOffset(32)] /* size = 4, padding = 0 */
        public sg_pixel_format pixel_format;

        [FieldOffset(36)] /* size = 4, padding = 0 */
        public int sample_count;

        [FieldOffset(40)] /* size = 4, padding = 0 */
        public sg_filter min_filter;

        [FieldOffset(44)] /* size = 4, padding = 0 */
        public sg_filter mag_filter;

        [FieldOffset(48)] /* size = 4, padding = 0 */
        public sg_wrap wrap_u;

        [FieldOffset(52)] /* size = 4, padding = 0 */
        public sg_wrap wrap_v;

        [FieldOffset(56)] /* size = 4, padding = 0 */
        public sg_wrap wrap_w;

        [FieldOffset(60)] /* size = 4, padding = 0 */
        public sg_border_color border_color;

        [FieldOffset(64)] /* size = 4, padding = 0 */
        public uint max_anisotropy;

        [FieldOffset(68)] /* size = 4, padding = 0 */
        public float min_lod;

        [FieldOffset(72)] /* size = 4, padding = 4 */
        public float max_lod;

        [FieldOffset(80)] /* size = 1536, padding = 0 */
        public sg_image_content content;

        [FieldOffset(1616)] /* size = 8, padding = 0 */
        public byte* label;

        [FieldOffset(1624)] /* size = 8, padding = 0 */
        public fixed uint gl_textures[2]; /* original type is `uint32_t [2]` */

        [FieldOffset(1632)] /* size = 16, padding = 0 */
        public fixed ulong _mtl_textures[16 / 8]; /* original type is `const void *[2]` */

        [FieldOffset(1648)] /* size = 8, padding = 0 */
        public void* d3d11_texture;

        [FieldOffset(1656)] /* size = 8, padding = 0 */
        public void* wgpu_texture;

        [FieldOffset(1664)] /* size = 4, padding = 4 */
        public uint _end_canary;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct sg_shader_attr_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public byte* name;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public byte* sem_name;

        [FieldOffset(16)] /* size = 4, padding = 4 */
        public int sem_index;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct sg_shader_uniform_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public byte* name;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_uniform_type type;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public int array_count;
    }

    [StructLayout(LayoutKind.Explicit, Size = 264, Pack = 8)]
    public struct sg_shader_uniform_block_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 4 */
        public int size;

        [FieldOffset(8)] /* size = 256, padding = 0 */
        public fixed ulong _uniforms[256 / 8]; /* original type is `sg_shader_uniform_desc [16]` */

        public readonly ref sg_shader_uniform_desc uniform(int index = 0)
        {
            fixed (sg_shader_uniform_block_desc* @this = &this)
            {
                var pointer = (sg_shader_uniform_desc*)&@this->_uniforms[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct sg_shader_image_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public byte* name;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_image_type type;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public sg_sampler_type sampler_type;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1280, Pack = 8)]
    public struct sg_shader_stage_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public byte* source;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public byte* byte_code;

        [FieldOffset(16)] /* size = 4, padding = 4 */
        public int byte_code_size;

        [FieldOffset(24)] /* size = 8, padding = 0 */
        public byte* entry;

        [FieldOffset(32)] /* size = 1056, padding = 0 */
        public fixed ulong _uniform_blocks[1056 / 8]; /* original type is `sg_shader_uniform_block_desc [4]` */

        [FieldOffset(1088)] /* size = 192, padding = 0 */
        public fixed ulong _images[192 / 8]; /* original type is `sg_shader_image_desc [12]` */

        public readonly ref sg_shader_uniform_block_desc uniform_block(int index = 0)
        {
            fixed (sg_shader_stage_desc* @this = &this)
            {
                var pointer = (sg_shader_uniform_block_desc*)&@this->_uniform_blocks[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }

        public readonly ref sg_shader_image_desc image(int index = 0)
        {
            fixed (sg_shader_stage_desc* @this = &this)
            {
                var pointer = (sg_shader_image_desc*)&@this->_images[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 2968, Pack = 8)]
    public struct sg_shader_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 4 */
        public uint _start_canary;

        [FieldOffset(8)] /* size = 384, padding = 0 */
        public fixed ulong _attrs[384 / 8]; /* original type is `sg_shader_attr_desc [16]` */

        [FieldOffset(392)] /* size = 1280, padding = 0 */
        public sg_shader_stage_desc vs;

        [FieldOffset(1672)] /* size = 1280, padding = 0 */
        public sg_shader_stage_desc fs;

        [FieldOffset(2952)] /* size = 8, padding = 0 */
        public byte* label;

        [FieldOffset(2960)] /* size = 4, padding = 4 */
        public uint _end_canary;

        public readonly ref sg_shader_attr_desc attr(int index = 0)
        {
            fixed (sg_shader_desc* @this = &this)
            {
                var pointer = (sg_shader_attr_desc*)&@this->_attrs[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_buffer_layout_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public int stride;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_vertex_step step_func;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int step_rate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_vertex_attr_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public int buffer_index;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public int offset;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_vertex_format format;
    }

    [StructLayout(LayoutKind.Explicit, Size = 288, Pack = 4)]
    public struct sg_layout_desc
    {
        [FieldOffset(0)] /* size = 96, padding = 0 */
        public fixed uint _buffers[96 / 4]; /* original type is `sg_buffer_layout_desc [8]` */

        [FieldOffset(96)] /* size = 192, padding = 0 */
        public fixed uint _attrs[192 / 4]; /* original type is `sg_vertex_attr_desc [16]` */

        public readonly ref sg_buffer_layout_desc buffer(int index = 0)
        {
            fixed (sg_layout_desc* @this = &this)
            {
                var pointer = (sg_buffer_layout_desc*)&@this->_buffers[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }

        public readonly ref sg_vertex_attr_desc attr(int index = 0)
        {
            fixed (sg_layout_desc* @this = &this)
            {
                var pointer = (sg_vertex_attr_desc*)&@this->_attrs[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
    public struct sg_stencil_state
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_stencil_op fail_op;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_stencil_op depth_fail_op;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_stencil_op pass_op;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public sg_compare_func compare_func;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44, Pack = 4)]
    public struct sg_depth_stencil_state
    {
        [FieldOffset(0)] /* size = 16, padding = 0 */
        public sg_stencil_state stencil_front;

        [FieldOffset(16)] /* size = 16, padding = 0 */
        public sg_stencil_state stencil_back;

        [FieldOffset(32)] /* size = 4, padding = 0 */
        public sg_compare_func depth_compare_func;

        [FieldOffset(36)] /* size = 1, padding = 0 */
        public BlittableBoolean depth_write_enabled;

        [FieldOffset(37)] /* size = 1, padding = 0 */
        public BlittableBoolean stencil_enabled;

        [FieldOffset(38)] /* size = 1, padding = 0 */
        public byte stencil_read_mask;

        [FieldOffset(39)] /* size = 1, padding = 0 */
        public byte stencil_write_mask;

        [FieldOffset(40)] /* size = 1, padding = 3 */
        public byte stencil_ref;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60, Pack = 4)]
    public struct sg_blend_state
    {
        [FieldOffset(0)] /* size = 1, padding = 3 */
        public BlittableBoolean enabled;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_blend_factor src_factor_rgb;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_blend_factor dst_factor_rgb;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public sg_blend_op op_rgb;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public sg_blend_factor src_factor_alpha;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public sg_blend_factor dst_factor_alpha;

        [FieldOffset(24)] /* size = 4, padding = 0 */
        public sg_blend_op op_alpha;

        [FieldOffset(28)] /* size = 1, padding = 3 */
        public byte color_write_mask;

        [FieldOffset(32)] /* size = 4, padding = 0 */
        public int color_attachment_count;

        [FieldOffset(36)] /* size = 4, padding = 0 */
        public sg_pixel_format color_format;

        [FieldOffset(40)] /* size = 4, padding = 0 */
        public sg_pixel_format depth_format;

        [FieldOffset(44)] /* size = 16, padding = 0 */
        public fixed float blend_color[4]; /* original type is `float [4]` */
    }

    [StructLayout(LayoutKind.Explicit, Size = 28, Pack = 4)]
    public struct sg_rasterizer_state
    {
        [FieldOffset(0)] /* size = 1, padding = 3 */
        public BlittableBoolean alpha_to_coverage_enabled;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_cull_mode cull_mode;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public sg_face_winding face_winding;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public int sample_count;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public float depth_bias;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public float depth_bias_slope_scale;

        [FieldOffset(24)] /* size = 4, padding = 0 */
        public float depth_bias_clamp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 456, Pack = 8)]
    public struct sg_pipeline_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 288, padding = 0 */
        public sg_layout_desc layout;

        [FieldOffset(292)] /* size = 4, padding = 0 */
        public sg_shader shader;

        [FieldOffset(296)] /* size = 4, padding = 0 */
        public sg_primitive_type primitive_type;

        [FieldOffset(300)] /* size = 4, padding = 0 */
        public sg_index_type index_type;

        [FieldOffset(304)] /* size = 44, padding = 0 */
        public sg_depth_stencil_state depth_stencil;

        [FieldOffset(348)] /* size = 60, padding = 0 */
        public sg_blend_state blend;

        [FieldOffset(408)] /* size = 28, padding = 4 */
        public sg_rasterizer_state rasterizer;

        [FieldOffset(440)] /* size = 8, padding = 0 */
        public byte* label;

        [FieldOffset(448)] /* size = 4, padding = 4 */
        public uint _end_canary;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_attachment_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_image image;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public int mip_level;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int face;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int layer;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int slice;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80, Pack = 8)]
    public struct sg_pass_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 48, padding = 0 */
        public fixed uint _color_attachments[48 / 4]; /* original type is `sg_attachment_desc [4]` */

        [FieldOffset(52)] /* size = 12, padding = 0 */
        public sg_attachment_desc depth_stencil_attachment;

        [FieldOffset(64)] /* size = 8, padding = 0 */
        public byte* label;

        [FieldOffset(72)] /* size = 4, padding = 4 */
        public uint _end_canary;

        public readonly ref sg_attachment_desc color_attachment(int index = 0)
        {
            fixed (sg_pass_desc* @this = &this)
            {
                var pointer = (sg_attachment_desc*)&@this->_color_attachments[0];
                var pointerOffset = index;
                return ref *(pointer + pointerOffset);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 408, Pack = 8)]
    public struct sg_trace_hooks
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public void* user_data;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public void* reset_state_cache;

        [FieldOffset(16)] /* size = 8, padding = 0 */
        public void* make_buffer;

        [FieldOffset(24)] /* size = 8, padding = 0 */
        public void* make_image;

        [FieldOffset(32)] /* size = 8, padding = 0 */
        public void* make_shader;

        [FieldOffset(40)] /* size = 8, padding = 0 */
        public void* make_pipeline;

        [FieldOffset(48)] /* size = 8, padding = 0 */
        public void* make_pass;

        [FieldOffset(56)] /* size = 8, padding = 0 */
        public void* destroy_buffer;

        [FieldOffset(64)] /* size = 8, padding = 0 */
        public void* destroy_image;

        [FieldOffset(72)] /* size = 8, padding = 0 */
        public void* destroy_shader;

        [FieldOffset(80)] /* size = 8, padding = 0 */
        public void* destroy_pipeline;

        [FieldOffset(88)] /* size = 8, padding = 0 */
        public void* destroy_pass;

        [FieldOffset(96)] /* size = 8, padding = 0 */
        public void* update_buffer;

        [FieldOffset(104)] /* size = 8, padding = 0 */
        public void* update_image;

        [FieldOffset(112)] /* size = 8, padding = 0 */
        public void* append_buffer;

        [FieldOffset(120)] /* size = 8, padding = 0 */
        public void* begin_default_pass;

        [FieldOffset(128)] /* size = 8, padding = 0 */
        public void* begin_pass;

        [FieldOffset(136)] /* size = 8, padding = 0 */
        public void* apply_viewport;

        [FieldOffset(144)] /* size = 8, padding = 0 */
        public void* apply_scissor_rect;

        [FieldOffset(152)] /* size = 8, padding = 0 */
        public void* apply_pipeline;

        [FieldOffset(160)] /* size = 8, padding = 0 */
        public void* apply_bindings;

        [FieldOffset(168)] /* size = 8, padding = 0 */
        public void* apply_uniforms;

        [FieldOffset(176)] /* size = 8, padding = 0 */
        public void* draw;

        [FieldOffset(184)] /* size = 8, padding = 0 */
        public void* end_pass;

        [FieldOffset(192)] /* size = 8, padding = 0 */
        public void* commit;

        [FieldOffset(200)] /* size = 8, padding = 0 */
        public void* alloc_buffer;

        [FieldOffset(208)] /* size = 8, padding = 0 */
        public void* alloc_image;

        [FieldOffset(216)] /* size = 8, padding = 0 */
        public void* alloc_shader;

        [FieldOffset(224)] /* size = 8, padding = 0 */
        public void* alloc_pipeline;

        [FieldOffset(232)] /* size = 8, padding = 0 */
        public void* alloc_pass;

        [FieldOffset(240)] /* size = 8, padding = 0 */
        public void* init_buffer;

        [FieldOffset(248)] /* size = 8, padding = 0 */
        public void* init_image;

        [FieldOffset(256)] /* size = 8, padding = 0 */
        public void* init_shader;

        [FieldOffset(264)] /* size = 8, padding = 0 */
        public void* init_pipeline;

        [FieldOffset(272)] /* size = 8, padding = 0 */
        public void* init_pass;

        [FieldOffset(280)] /* size = 8, padding = 0 */
        public void* fail_buffer;

        [FieldOffset(288)] /* size = 8, padding = 0 */
        public void* fail_image;

        [FieldOffset(296)] /* size = 8, padding = 0 */
        public void* fail_shader;

        [FieldOffset(304)] /* size = 8, padding = 0 */
        public void* fail_pipeline;

        [FieldOffset(312)] /* size = 8, padding = 0 */
        public void* fail_pass;

        [FieldOffset(320)] /* size = 8, padding = 0 */
        public void* push_debug_group;

        [FieldOffset(328)] /* size = 8, padding = 0 */
        public void* pop_debug_group;

        [FieldOffset(336)] /* size = 8, padding = 0 */
        public void* err_buffer_pool_exhausted;

        [FieldOffset(344)] /* size = 8, padding = 0 */
        public void* err_image_pool_exhausted;

        [FieldOffset(352)] /* size = 8, padding = 0 */
        public void* err_shader_pool_exhausted;

        [FieldOffset(360)] /* size = 8, padding = 0 */
        public void* err_pipeline_pool_exhausted;

        [FieldOffset(368)] /* size = 8, padding = 0 */
        public void* err_pass_pool_exhausted;

        [FieldOffset(376)] /* size = 8, padding = 0 */
        public void* err_context_mismatch;

        [FieldOffset(384)] /* size = 8, padding = 0 */
        public void* err_pass_invalid;

        [FieldOffset(392)] /* size = 8, padding = 0 */
        public void* err_draw_invalid;

        [FieldOffset(400)] /* size = 8, padding = 0 */
        public void* err_bindings_invalid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_slot_info
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_resource_state state;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public uint res_id;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public uint ctx_id;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36, Pack = 4)]
    public struct sg_buffer_info
    {
        [FieldOffset(0)] /* size = 12, padding = 0 */
        public sg_slot_info slot;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public uint update_frame_index;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public uint append_frame_index;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public int append_pos;

        [FieldOffset(24)] /* size = 1, padding = 3 */
        public BlittableBoolean append_overflow;

        [FieldOffset(28)] /* size = 4, padding = 0 */
        public int num_slots;

        [FieldOffset(32)] /* size = 4, padding = 0 */
        public int active_slot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
    public struct sg_image_info
    {
        [FieldOffset(0)] /* size = 12, padding = 0 */
        public sg_slot_info slot;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public uint upd_frame_index;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public int num_slots;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public int active_slot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_shader_info
    {
        [FieldOffset(0)] /* size = 12, padding = 0 */
        public sg_slot_info slot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_pipeline_info
    {
        [FieldOffset(0)] /* size = 12, padding = 0 */
        public sg_slot_info slot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 4)]
    public struct sg_pass_info
    {
        [FieldOffset(0)] /* size = 12, padding = 0 */
        public sg_slot_info slot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1, Pack = 1)]
    public struct sg_gl_context_desc
    {
        [FieldOffset(0)] /* size = 1, padding = 0 */
        public BlittableBoolean force_gles2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 8)]
    public struct sg_mtl_context_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public void* device;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public void* renderpass_descriptor_cb;

        [FieldOffset(16)] /* size = 8, padding = 0 */
        public void* drawable_cb;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public struct sg_d3d11_context_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public void* device;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public void* device_context;

        [FieldOffset(16)] /* size = 8, padding = 0 */
        public void* render_target_view_cb;

        [FieldOffset(24)] /* size = 8, padding = 0 */
        public void* depth_stencil_view_cb;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public struct sg_wgpu_context_desc
    {
        [FieldOffset(0)] /* size = 8, padding = 0 */
        public void* device;

        [FieldOffset(8)] /* size = 8, padding = 0 */
        public void* render_view_cb;

        [FieldOffset(16)] /* size = 8, padding = 0 */
        public void* resolve_view_cb;

        [FieldOffset(24)] /* size = 8, padding = 0 */
        public void* depth_stencil_view_cb;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104, Pack = 8)]
    public struct sg_context_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public sg_pixel_format color_format;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public sg_pixel_format depth_format;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int sample_count;

        [FieldOffset(12)] /* size = 1, padding = 3 */
        public sg_gl_context_desc gl;

        [FieldOffset(16)] /* size = 24, padding = 0 */
        public sg_mtl_context_desc metal;

        [FieldOffset(40)] /* size = 32, padding = 0 */
        public sg_d3d11_context_desc d3d11;

        [FieldOffset(72)] /* size = 32, padding = 0 */
        public sg_wgpu_context_desc wgpu;
    }

    [StructLayout(LayoutKind.Explicit, Size = 152, Pack = 8)]
    public struct sg_desc
    {
        [FieldOffset(0)] /* size = 4, padding = 0 */
        public uint _start_canary;

        [FieldOffset(4)] /* size = 4, padding = 0 */
        public int buffer_pool_size;

        [FieldOffset(8)] /* size = 4, padding = 0 */
        public int image_pool_size;

        [FieldOffset(12)] /* size = 4, padding = 0 */
        public int shader_pool_size;

        [FieldOffset(16)] /* size = 4, padding = 0 */
        public int pipeline_pool_size;

        [FieldOffset(20)] /* size = 4, padding = 0 */
        public int pass_pool_size;

        [FieldOffset(24)] /* size = 4, padding = 0 */
        public int context_pool_size;

        [FieldOffset(28)] /* size = 4, padding = 0 */
        public int uniform_buffer_size;

        [FieldOffset(32)] /* size = 4, padding = 0 */
        public int staging_buffer_size;

        [FieldOffset(36)] /* size = 4, padding = 0 */
        public int sampler_cache_size;

        [FieldOffset(40)] /* size = 104, padding = 0 */
        public sg_context_desc context;

        [FieldOffset(144)] /* size = 4, padding = 4 */
        public uint _end_canary;
    }

    [DllImport(LibraryName)]
    public static extern void sg_setup([In] sg_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_shutdown();

    [DllImport(LibraryName)]
    public static extern BlittableBoolean sg_isvalid();

    [DllImport(LibraryName)]
    public static extern void sg_reset_state_cache();

    [DllImport(LibraryName)]
    public static extern sg_trace_hooks sg_install_trace_hooks([In] sg_trace_hooks* trace_hooks);

    [DllImport(LibraryName)]
    public static extern void sg_push_debug_group([In] byte* name);

    [DllImport(LibraryName)]
    public static extern void sg_pop_debug_group();

    [DllImport(LibraryName)]
    public static extern sg_buffer sg_make_buffer([In] sg_buffer_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_image sg_make_image([In] sg_image_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_shader sg_make_shader([In] sg_shader_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_pipeline sg_make_pipeline([In] sg_pipeline_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_pass sg_make_pass([In] sg_pass_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_destroy_buffer(sg_buffer buf);

    [DllImport(LibraryName)]
    public static extern void sg_destroy_image(sg_image img);

    [DllImport(LibraryName)]
    public static extern void sg_destroy_shader(sg_shader shd);

    [DllImport(LibraryName)]
    public static extern void sg_destroy_pipeline(sg_pipeline pip);

    [DllImport(LibraryName)]
    public static extern void sg_destroy_pass(sg_pass pass);

    [DllImport(LibraryName)]
    public static extern void sg_update_buffer(sg_buffer buf, [In] void* data_ptr, int data_size);

    [DllImport(LibraryName)]
    public static extern void sg_update_image(sg_image img, [In] sg_image_content* data);

    [DllImport(LibraryName)]
    public static extern int sg_append_buffer(sg_buffer buf, [In] void* data_ptr, int data_size);

    [DllImport(LibraryName)]
    public static extern BlittableBoolean sg_query_buffer_overflow(sg_buffer buf);

    [DllImport(LibraryName)]
    public static extern void sg_begin_default_pass([In] sg_pass_action* pass_action, int width, int height);

    [DllImport(LibraryName)]
    public static extern void sg_begin_pass(sg_pass pass, [In] sg_pass_action* pass_action);

    [DllImport(LibraryName)]
    public static extern void sg_apply_viewport(int x, int y, int width, int height, BlittableBoolean origin_top_left);

    [DllImport(LibraryName)]
    public static extern void sg_apply_scissor_rect(int x, int y, int width, int height, BlittableBoolean origin_top_left);

    [DllImport(LibraryName)]
    public static extern void sg_apply_pipeline(sg_pipeline pip);

    [DllImport(LibraryName)]
    public static extern void sg_apply_bindings([In] sg_bindings* bindings);

    [DllImport(LibraryName)]
    public static extern void sg_apply_uniforms(sg_shader_stage stage, int ub_index, [In] void* data, int num_bytes);

    [DllImport(LibraryName)]
    public static extern void sg_draw(int base_element, int num_elements, int num_instances);

    [DllImport(LibraryName)]
    public static extern void sg_end_pass();

    [DllImport(LibraryName)]
    public static extern void sg_commit();

    [DllImport(LibraryName)]
    public static extern sg_desc sg_query_desc();

    [DllImport(LibraryName)]
    public static extern sg_backend sg_query_backend();

    [DllImport(LibraryName)]
    public static extern sg_features sg_query_features();

    [DllImport(LibraryName)]
    public static extern sg_limits sg_query_limits();

    [DllImport(LibraryName)]
    public static extern sg_pixelformat_info sg_query_pixelformat(sg_pixel_format fmt);

    [DllImport(LibraryName)]
    public static extern sg_resource_state sg_query_buffer_state(sg_buffer buf);

    [DllImport(LibraryName)]
    public static extern sg_resource_state sg_query_image_state(sg_image img);

    [DllImport(LibraryName)]
    public static extern sg_resource_state sg_query_shader_state(sg_shader shd);

    [DllImport(LibraryName)]
    public static extern sg_resource_state sg_query_pipeline_state(sg_pipeline pip);

    [DllImport(LibraryName)]
    public static extern sg_resource_state sg_query_pass_state(sg_pass pass);

    [DllImport(LibraryName)]
    public static extern sg_buffer_info sg_query_buffer_info(sg_buffer buf);

    [DllImport(LibraryName)]
    public static extern sg_image_info sg_query_image_info(sg_image img);

    [DllImport(LibraryName)]
    public static extern sg_shader_info sg_query_shader_info(sg_shader shd);

    [DllImport(LibraryName)]
    public static extern sg_pipeline_info sg_query_pipeline_info(sg_pipeline pip);

    [DllImport(LibraryName)]
    public static extern sg_pass_info sg_query_pass_info(sg_pass pass);

    [DllImport(LibraryName)]
    public static extern sg_buffer_desc sg_query_buffer_defaults([In] sg_buffer_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_image_desc sg_query_image_defaults([In] sg_image_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_shader_desc sg_query_shader_defaults([In] sg_shader_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_pipeline_desc sg_query_pipeline_defaults([In] sg_pipeline_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_pass_desc sg_query_pass_defaults([In] sg_pass_desc* desc);

    [DllImport(LibraryName)]
    public static extern sg_buffer sg_alloc_buffer();

    [DllImport(LibraryName)]
    public static extern sg_image sg_alloc_image();

    [DllImport(LibraryName)]
    public static extern sg_shader sg_alloc_shader();

    [DllImport(LibraryName)]
    public static extern sg_pipeline sg_alloc_pipeline();

    [DllImport(LibraryName)]
    public static extern sg_pass sg_alloc_pass();

    [DllImport(LibraryName)]
    public static extern void sg_init_buffer(sg_buffer buf_id, [In] sg_buffer_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_init_image(sg_image img_id, [In] sg_image_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_init_shader(sg_shader shd_id, [In] sg_shader_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_init_pipeline(sg_pipeline pip_id, [In] sg_pipeline_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_init_pass(sg_pass pass_id, [In] sg_pass_desc* desc);

    [DllImport(LibraryName)]
    public static extern void sg_fail_buffer(sg_buffer buf_id);

    [DllImport(LibraryName)]
    public static extern void sg_fail_image(sg_image img_id);

    [DllImport(LibraryName)]
    public static extern void sg_fail_shader(sg_shader shd_id);

    [DllImport(LibraryName)]
    public static extern void sg_fail_pipeline(sg_pipeline pip_id);

    [DllImport(LibraryName)]
    public static extern void sg_fail_pass(sg_pass pass_id);

    [DllImport(LibraryName)]
    public static extern sg_context sg_setup_context();

    [DllImport(LibraryName)]
    public static extern void sg_activate_context(sg_context ctx_id);

    [DllImport(LibraryName)]
    public static extern void sg_discard_context(sg_context ctx_id);
}
