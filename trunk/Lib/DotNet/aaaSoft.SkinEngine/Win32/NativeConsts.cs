﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Win32
{
    public static class NativeConsts
    {
        #region WH常量 - Windows Hook类型枚举

        /// <summary>
        /// 钩子类型枚举
        /// </summary>
        public enum HookType : int
        {
            WH_MSGFILTER = -1,
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        #endregion

        #region HC常量 - 钩子回调nCode枚举
        public enum HC : int
        {
            HC_ACTION = 0,
            HC_GETNEXT = 1,
            HC_SKIP = 2,
            HC_NOREMOVE = 3,
            HC_SYSMODALON = 4,
            HC_SYSMODALOFF = 5
        }
        #endregion

        #region HT常量 - WM_NCHITTEST枚举
        public enum HT : int
        {
            HTCLIENT = 1,
            HTCAPTION = 2,
            HTMINBUTTON = 8,
            HTZOOM = 9,
            HTMAXBUTTON = 9,
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17,
            HTBORDER = 18,
            HTCLOSE = 20
        }
        #endregion

        #region SB常量 - ScrollBar消息枚举
        public enum SB
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,

            SB_LINELEFT = 0,
            SB_LINERIGHT = 1,
            SB_PAGELEFT = 2,
            SB_PAGERIGHT = 3,
            SB_THUMBPOSITION = 4,
            SB_THUMBTRACK = 5,
            SB_LEFT = 6,
            SB_RIGHT = 7,
            SB_ENDSCROLL = 8
        }
        #endregion

        #region TME常量
        public enum TME : uint
        {
            LEAVE = 0x2,
            NONCLIENT = 0x10
        }
        #endregion

        #region 鼠标事件常量
        public enum MouseEventFlags
        {
            LeftDown = 0x2,
            LeftUp = 0x4,
            Click = LeftDown + LeftUp,
            MiddleDown = 0x20,
            MiddleUp = 0x40,
            Move = 0x1,
            Absolute = 0x8000,
            RightDown = 0x8,
            RightUp = 0x10
        }
        #endregion

        #region Windows消息常量
        /// <summary>
        /// Windows消息常量
        /// </summary>
        public enum WindowMessage : int
        {
            WM_NULL = 0x0000,
            WM_CREATE = 0x0001,
            WM_DESTROY = 0x0002,
            WM_MOVE = 0x0003,
            WM_SIZE = 0x0005,
            WM_ACTIVATE = 0x0006,
            WM_SETFOCUS = 0x0007,
            WM_KILLFOCUS = 0x0008,
            WM_ENABLE = 0x000A,
            WM_SETREDRAW = 0x000B,
            WM_SETTEXT = 0x000C,
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,
            WM_PAINT = 0x000F,
            WM_CLOSE = 0x0010,
            WM_QUERYENDSESSION = 0x0011,
            WM_QUERYOPEN = 0x0013,
            WM_ENDSESSION = 0x0016,
            WM_QUIT = 0x0012,
            WM_ERASEBKGND = 0x0014,
            WM_SYSCOLORCHANGE = 0x0015,
            WM_SHOWWINDOW = 0x0018,
            WM_WININICHANGE = 0x001A,
            WM_SETTINGCHANGE = 0x001A,
            WM_DEVMODECHANGE = 0x001B,
            WM_ACTIVATEAPP = 0x001C,
            WM_FONTCHANGE = 0x001D,
            WM_TIMECHANGE = 0x001E,
            WM_CANCELMODE = 0x001F,
            WM_SETCURSOR = 0x0020,
            WM_MOUSEACTIVATE = 0x0021,
            WM_CHILDACTIVATE = 0x0022,
            WM_QUEUESYNC = 0x0023,
            WM_GETMINMAXINFO = 0x0024,
            WM_PAINTICON = 0x0026,
            WM_ICONERASEBKGND = 0x0027,
            WM_NEXTDLGCTL = 0x0028,
            WM_SPOOLERSTATUS = 0x002A,
            WM_DRAWITEM = 0x002B,
            WM_MEASUREITEM = 0x002C,
            WM_DELETEITEM = 0x002D,
            WM_VKEYTOITEM = 0x002E,
            WM_CHARTOITEM = 0x002F,
            WM_SETFONT = 0x0030,
            WM_GETFONT = 0x0031,
            WM_SETHOTKEY = 0x0032,
            WM_GETHOTKEY = 0x0033,
            WM_QUERYDRAGICON = 0x0037,
            WM_COMPAREITEM = 0x0039,
            WM_GETOBJECT = 0x003D,
            WM_COMPACTING = 0x0041,
            WM_COMMNOTIFY = 0x0044,
            WM_WINDOWPOSCHANGING = 0x0046,
            WM_WINDOWPOSCHANGED = 0x0047,
            WM_POWER = 0x0048,
            WM_COPYDATA = 0x004A,
            WM_CANCELJOURNAL = 0x004B,
            WM_NOTIFY = 0x004E,
            WM_INPUTLANGCHANGEREQUEST = 0x0050,
            WM_INPUTLANGCHANGE = 0x0051,
            WM_TCARD = 0x0052,
            WM_HELP = 0x0053,
            WM_USERCHANGED = 0x0054,
            WM_NOTIFYFORMAT = 0x0055,
            WM_CONTEXTMENU = 0x007B,
            WM_STYLECHANGING = 0x007C,
            WM_STYLECHANGED = 0x007D,
            WM_DISPLAYCHANGE = 0x007E,
            WM_GETICON = 0x007F,
            WM_SETICON = 0x0080,
            WM_NCCREATE = 0x0081,
            WM_NCDESTROY = 0x0082,
            WM_NCCALCSIZE = 0x0083,
            WM_NCHITTEST = 0x0084,
            WM_NCPAINT = 0x0085,
            WM_NCACTIVATE = 0x0086,
            WM_GETDLGCODE = 0x0087,
            WM_SYNCPAINT = 0x0088,
            WM_NCMOUSEMOVE = 0x00A0,
            WM_NCLBUTTONDOWN = 0x00A1,
            WM_NCLBUTTONUP = 0x00A2,
            WM_NCLBUTTONDBLCLK = 0x00A3,
            WM_NCRBUTTONDOWN = 0x00A4,
            WM_NCRBUTTONUP = 0x00A5,
            WM_NCRBUTTONDBLCLK = 0x00A6,
            WM_NCMBUTTONDOWN = 0x00A7,
            WM_NCMBUTTONUP = 0x00A8,
            WM_NCMBUTTONDBLCLK = 0x00A9,
            WM_NCXBUTTONDOWN = 0x00AB,
            WM_NCXBUTTONUP = 0x00AC,
            WM_NCXBUTTONDBLCLK = 0x00AD,
            /// <summary>
            /// 画系统按钮时(此消息于MDSN中不可查询，aaaSoft命名此消息)
            /// </summary>
            WM_SYSCTLPAINT = 0x00AE,

            WM_INPUT = 0x00FF,
            WM_KEYFIRST = 0x0100,
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_DEADCHAR = 0x0103,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105,
            WM_SYSCHAR = 0x0106,
            WM_SYSDEADCHAR = 0x0107,
            WM_UNICHAR = 0x0109,
            WM_KEYLAST_NT501 = 0x0109,
            UNICODE_NOCHAR = 0xFFFF,
            WM_KEYLAST_PRE501 = 0x0108,
            WM_IME_STARTCOMPOSITION = 0x010D,
            WM_IME_ENDCOMPOSITION = 0x010E,
            WM_IME_COMPOSITION = 0x010F,
            WM_IME_KEYLAST = 0x010F,
            WM_INITDIALOG = 0x0110,
            WM_COMMAND = 0x0111,
            WM_SYSCOMMAND = 0x0112,
            WM_TIMER = 0x0113,
            WM_HSCROLL = 0x0114,
            WM_VSCROLL = 0x0115,
            WM_INITMENU = 0x0116,
            WM_INITMENUPOPUP = 0x0117,
            WM_MENUSELECT = 0x011F,
            WM_MENUCHAR = 0x0120,
            WM_ENTERIDLE = 0x0121,
            WM_MENURBUTTONUP = 0x0122,
            WM_MENUDRAG = 0x0123,
            WM_MENUGETOBJECT = 0x0124,
            WM_UNINITMENUPOPUP = 0x0125,
            WM_MENUCOMMAND = 0x0126,
            WM_CHANGEUISTATE = 0x0127,
            WM_UPDATEUISTATE = 0x0128,
            WM_QUERYUISTATE = 0x0129,
            WM_CTLCOLORMSGBOX = 0x0132,
            WM_CTLCOLOREDIT = 0x0133,
            WM_CTLCOLORLISTBOX = 0x0134,
            WM_CTLCOLORBTN = 0x0135,
            WM_CTLCOLORDLG = 0x0136,
            WM_CTLCOLORSCROLLBAR = 0x0137,
            WM_CTLCOLORSTATIC = 0x0138,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEFIRST = 0x0200,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_LBUTTONDBLCLK = 0x0203,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_RBUTTONDBLCLK = 0x0206,
            WM_MBUTTONDOWN = 0x0207,
            WM_MBUTTONUP = 0x0208,
            WM_MBUTTONDBLCLK = 0x0209,
            WM_MOUSEWHEEL = 0x020A,
            WM_XBUTTONDOWN = 0x020B,
            WM_XBUTTONUP = 0x020C,
            WM_XBUTTONDBLCLK = 0x020D,
            WM_MOUSELAST_5 = 0x020D,
            WM_MOUSELAST_4 = 0x020A,
            WM_MOUSELAST_PRE_4 = 0x0209,
            WM_PARENTNOTIFY = 0x0210,
            WM_ENTERMENULOOP = 0x0211,
            WM_EXITMENULOOP = 0x0212,
            WM_NEXTMENU = 0x0213,
            WM_SIZING = 0x0214,
            WM_CAPTURECHANGED = 0x0215,
            WM_MOVING = 0x0216,
            WM_POWERBROADCAST = 0x0218,
            WM_DEVICECHANGE = 0x0219,
            WM_MDICREATE = 0x0220,
            WM_MDIDESTROY = 0x0221,
            WM_MDIACTIVATE = 0x0222,
            WM_MDIRESTORE = 0x0223,
            WM_MDINEXT = 0x0224,
            WM_MDIMAXIMIZE = 0x0225,
            WM_MDITILE = 0x0226,
            WM_MDICASCADE = 0x0227,
            WM_MDIICONARRANGE = 0x0228,
            WM_MDIGETACTIVE = 0x0229,
            WM_MDISETMENU = 0x0230,
            WM_ENTERSIZEMOVE = 0x0231,
            WM_EXITSIZEMOVE = 0x0232,
            WM_DROPFILES = 0x0233,
            WM_MDIREFRESHMENU = 0x0234,
            WM_IME_SETCONTEXT = 0x0281,
            WM_IME_NOTIFY = 0x0282,
            WM_IME_CONTROL = 0x0283,
            WM_IME_COMPOSITIONFULL = 0x0284,
            WM_IME_SELECT = 0x0285,
            WM_IME_CHAR = 0x0286,
            WM_IME_REQUEST = 0x0288,
            WM_IME_KEYDOWN = 0x0290,
            WM_IME_KEYUP = 0x0291,
            WM_MOUSEHOVER = 0x02A1,
            WM_MOUSELEAVE = 0x02A3,
            WM_NCMOUSEHOVER = 0x02A0,
            WM_NCMOUSELEAVE = 0x02A2,
            WM_WTSSESSION_CHANGE = 0x02B1,
            WM_TABLET_FIRST = 0x02c0,
            WM_TABLET_LAST = 0x02df,
            WM_CUT = 0x0300,
            WM_COPY = 0x0301,
            WM_PASTE = 0x0302,
            WM_CLEAR = 0x0303,
            WM_UNDO = 0x0304,
            WM_RENDERFORMAT = 0x0305,
            WM_RENDERALLFORMATS = 0x0306,
            WM_DESTROYCLIPBOARD = 0x0307,
            WM_DRAWCLIPBOARD = 0x0308,
            WM_PAINTCLIPBOARD = 0x0309,
            WM_VSCROLLCLIPBOARD = 0x030A,
            WM_SIZECLIPBOARD = 0x030B,
            WM_ASKCBFORMATNAME = 0x030C,
            WM_CHANGECBCHAIN = 0x030D,
            WM_HSCROLLCLIPBOARD = 0x030E,
            WM_QUERYNEWPALETTE = 0x030F,
            WM_PALETTEISCHANGING = 0x0310,
            WM_PALETTECHANGED = 0x0311,
            WM_HOTKEY = 0x0312,
            WM_PRINT = 0x0317,
            WM_PRINTCLIENT = 0x0318,
            WM_APPCOMMAND = 0x0319,
            WM_THEMECHANGED = 0x031A,
            WM_HANDHELDFIRST = 0x0358,
            WM_HANDHELDLAST = 0x035F,
            WM_AFXFIRST = 0x0360,
            WM_AFXLAST = 0x037F,
            WM_PENWINFIRST = 0x0380,
            WM_PENWINLAST = 0x038F,
            WM_APP = 0x8000,
            WM_USER = 0x0400,
            EM_GETSEL = 0x00B0,
            EM_SETSEL = 0x00B1,
            EM_GETRECT = 0x00B2,
            EM_SETRECT = 0x00B3,
            EM_SETRECTNP = 0x00B4,
            EM_SCROLL = 0x00B5,
            EM_LINESCROLL = 0x00B6,
            EM_SCROLLCARET = 0x00B7,
            EM_GETMODIFY = 0x00B8,
            EM_SETMODIFY = 0x00B9,
            EM_GETLINECOUNT = 0x00BA,
            EM_LINEINDEX = 0x00BB,
            EM_SETHANDLE = 0x00BC,
            EM_GETHANDLE = 0x00BD,
            EM_GETTHUMB = 0x00BE,
            EM_LINELENGTH = 0x00C1,
            EM_REPLACESEL = 0x00C2,
            EM_GETLINE = 0x00C4,
            EM_LIMITTEXT = 0x00C5,
            EM_CANUNDO = 0x00C6,
            EM_UNDO = 0x00C7,
            EM_FMTLINES = 0x00C8,
            EM_LINEFROMCHAR = 0x00C9,
            EM_SETTABSTOPS = 0x00CB,
            EM_SETPASSWORDCHAR = 0x00CC,
            EM_EMPTYUNDOBUFFER = 0x00CD,
            EM_GETFIRSTVISIBLELINE = 0x00CE,
            EM_SETREADONLY = 0x00CF,
            EM_SETWORDBREAKPROC = 0x00D0,
            EM_GETWORDBREAKPROC = 0x00D1,
            EM_GETPASSWORDCHAR = 0x00D2,
            EM_SETMARGINS = 0x00D3,
            EM_GETMARGINS = 0x00D4,
            EM_SETLIMITTEXT = EM_LIMITTEXT,
            EM_GETLIMITTEXT = 0x00D5,
            EM_POSFROMCHAR = 0x00D6,
            EM_CHARFROMPOS = 0x00D7,
            EM_SETIMESTATUS = 0x00D8,
            EM_GETIMESTATUS = 0x00D9,
            BM_GETCHECK = 0x00F0,
            BM_SETCHECK = 0x00F1,
            BM_GETSTATE = 0x00F2,
            BM_SETSTATE = 0x00F3,
            BM_SETSTYLE = 0x00F4,
            BM_CLICK = 0x00F5,
            BM_GETIMAGE = 0x00F6,
            BM_SETIMAGE = 0x00F7,
            STM_SETICON = 0x0170,
            STM_GETICON = 0x0171,
            STM_SETIMAGE = 0x0172,
            STM_GETIMAGE = 0x0173,
            STM_MSGMAX = 0x0174,
            DM_GETDEFID = (WM_USER + 0),
            DM_SETDEFID = (WM_USER + 1),
            DM_REPOSITION = (WM_USER + 2),
            LB_ADDSTRING = 0x0180,
            LB_INSERTSTRING = 0x0181,
            LB_DELETESTRING = 0x0182,
            LB_SELITEMRANGEEX = 0x0183,
            LB_RESETCONTENT = 0x0184,
            LB_SETSEL = 0x0185,
            LB_SETCURSEL = 0x0186,
            LB_GETSEL = 0x0187,
            LB_GETCURSEL = 0x0188,
            LB_GETTEXT = 0x0189,
            LB_GETTEXTLEN = 0x018A,
            LB_GETCOUNT = 0x018B,
            LB_SELECTSTRING = 0x018C,
            LB_DIR = 0x018D,
            LB_GETTOPINDEX = 0x018E,
            LB_FINDSTRING = 0x018F,
            LB_GETSELCOUNT = 0x0190,
            LB_GETSELITEMS = 0x0191,
            LB_SETTABSTOPS = 0x0192,
            LB_GETHORIZONTALEXTENT = 0x0193,
            LB_SETHORIZONTALEXTENT = 0x0194,
            LB_SETCOLUMNWIDTH = 0x0195,
            LB_ADDFILE = 0x0196,
            LB_SETTOPINDEX = 0x0197,
            LB_GETITEMRECT = 0x0198,
            LB_GETITEMDATA = 0x0199,
            LB_SETITEMDATA = 0x019A,
            LB_SELITEMRANGE = 0x019B,
            LB_SETANCHORINDEX = 0x019C,
            LB_GETANCHORINDEX = 0x019D,
            LB_SETCARETINDEX = 0x019E,
            LB_GETCARETINDEX = 0x019F,
            LB_SETITEMHEIGHT = 0x01A0,
            LB_GETITEMHEIGHT = 0x01A1,
            LB_FINDSTRINGEXACT = 0x01A2,
            LB_SETLOCALE = 0x01A5,
            LB_GETLOCALE = 0x01A6,
            LB_SETCOUNT = 0x01A7,
            LB_INITSTORAGE = 0x01A8,
            LB_ITEMFROMPOINT = 0x01A9,
            LB_MULTIPLEADDSTRING = 0x01B1,
            LB_GETLISTBOXINFO = 0x01B2,
            LB_MSGMAX_501 = 0x01B3,
            LB_MSGMAX_WCE4 = 0x01B1,
            LB_MSGMAX_4 = 0x01B0,
            LB_MSGMAX_PRE4 = 0x01A8,
            CB_GETEDITSEL = 0x0140,
            CB_LIMITTEXT = 0x0141,
            CB_SETEDITSEL = 0x0142,
            CB_ADDSTRING = 0x0143,
            CB_DELETESTRING = 0x0144,
            CB_DIR = 0x0145,
            CB_GETCOUNT = 0x0146,
            CB_GETCURSEL = 0x0147,
            CB_GETLBTEXT = 0x0148,
            CB_GETLBTEXTLEN = 0x0149,
            CB_INSERTSTRING = 0x014A,
            CB_RESETCONTENT = 0x014B,
            CB_FINDSTRING = 0x014C,
            CB_SELECTSTRING = 0x014D,
            CB_SETCURSEL = 0x014E,
            CB_SHOWDROPDOWN = 0x014F,
            CB_GETITEMDATA = 0x0150,
            CB_SETITEMDATA = 0x0151,
            CB_GETDROPPEDCONTROLRECT = 0x0152,
            CB_SETITEMHEIGHT = 0x0153,
            CB_GETITEMHEIGHT = 0x0154,
            CB_SETEXTENDEDUI = 0x0155,
            CB_GETEXTENDEDUI = 0x0156,
            CB_GETDROPPEDSTATE = 0x0157,
            CB_FINDSTRINGEXACT = 0x0158,
            CB_SETLOCALE = 0x0159,
            CB_GETLOCALE = 0x015A,
            CB_GETTOPINDEX = 0x015B,
            CB_SETTOPINDEX = 0x015C,
            CB_GETHORIZONTALEXTENT = 0x015d,
            CB_SETHORIZONTALEXTENT = 0x015e,
            CB_GETDROPPEDWIDTH = 0x015f,
            CB_SETDROPPEDWIDTH = 0x0160,
            CB_INITSTORAGE = 0x0161,
            CB_MULTIPLEADDSTRING = 0x0163,
            CB_GETCOMBOBOXINFO = 0x0164,
            CB_MSGMAX_501 = 0x0165,
            CB_MSGMAX_WCE400 = 0x0163,
            CB_MSGMAX_400 = 0x0162,
            CB_MSGMAX_PRE400 = 0x015B,
            SBM_SETPOS = 0x00E0,
            SBM_GETPOS = 0x00E1,
            SBM_SETRANGE = 0x00E2,
            SBM_SETRANGEREDRAW = 0x00E6,
            SBM_GETRANGE = 0x00E3,
            SBM_ENABLE_ARROWS = 0x00E4,
            SBM_SETSCROLLINFO = 0x00E9,
            SBM_GETSCROLLINFO = 0x00EA,
            SBM_GETSCROLLBARINFO = 0x00EB,
            LVM_FIRST = 0x1000,// ListView messages
            TV_FIRST = 0x1100,// TreeView messages
            HDM_FIRST = 0x1200,// Header messages
            TCM_FIRST = 0x1300,// Tab control messages
            PGM_FIRST = 0x1400,// Pager control messages
            ECM_FIRST = 0x1500,// Edit control messages
            BCM_FIRST = 0x1600,// Button control messages
            CBM_FIRST = 0x1700,// Combobox control messages
            CCM_FIRST = 0x2000,// Common control shared messages
            CCM_LAST = (CCM_FIRST + 0x200),
            CCM_SETBKCOLOR = (CCM_FIRST + 1),
            CCM_SETCOLORSCHEME = (CCM_FIRST + 2),
            CCM_GETCOLORSCHEME = (CCM_FIRST + 3),
            CCM_GETDROPTARGET = (CCM_FIRST + 4),
            CCM_SETUNICODEFORMAT = (CCM_FIRST + 5),
            CCM_GETUNICODEFORMAT = (CCM_FIRST + 6),
            CCM_SETVERSION = (CCM_FIRST + 0x7),
            CCM_GETVERSION = (CCM_FIRST + 0x8),
            CCM_SETNOTIFYWINDOW = (CCM_FIRST + 0x9),
            CCM_SETWINDOWTHEME = (CCM_FIRST + 0xb),
            CCM_DPISCALE = (CCM_FIRST + 0xc),
            HDM_GETITEMCOUNT = (HDM_FIRST + 0),
            HDM_INSERTITEMA = (HDM_FIRST + 1),
            HDM_INSERTITEMW = (HDM_FIRST + 10),
            HDM_DELETEITEM = (HDM_FIRST + 2),
            HDM_GETITEMA = (HDM_FIRST + 3),
            HDM_GETITEMW = (HDM_FIRST + 11),
            HDM_SETITEMA = (HDM_FIRST + 4),
            HDM_SETITEMW = (HDM_FIRST + 12),
            HDM_LAYOUT = (HDM_FIRST + 5),
            HDM_HITTEST = (HDM_FIRST + 6),
            HDM_GETITEMRECT = (HDM_FIRST + 7),
            HDM_SETIMAGELIST = (HDM_FIRST + 8),
            HDM_GETIMAGELIST = (HDM_FIRST + 9),
            HDM_ORDERTOINDEX = (HDM_FIRST + 15),
            HDM_CREATEDRAGIMAGE = (HDM_FIRST + 16),
            HDM_GETORDERARRAY = (HDM_FIRST + 17),
            HDM_SETORDERARRAY = (HDM_FIRST + 18),
            HDM_SETHOTDIVIDER = (HDM_FIRST + 19),
            HDM_SETBITMAPMARGIN = (HDM_FIRST + 20),
            HDM_GETBITMAPMARGIN = (HDM_FIRST + 21),
            HDM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
            HDM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
            HDM_SETFILTERCHANGETIMEOUT = (HDM_FIRST + 22),
            HDM_EDITFILTER = (HDM_FIRST + 23),
            HDM_CLEARFILTER = (HDM_FIRST + 24),
            TB_ENABLEBUTTON = (WM_USER + 1),
            TB_CHECKBUTTON = (WM_USER + 2),
            TB_PRESSBUTTON = (WM_USER + 3),
            TB_HIDEBUTTON = (WM_USER + 4),
            TB_INDETERMINATE = (WM_USER + 5),
            TB_MARKBUTTON = (WM_USER + 6),
            TB_ISBUTTONENABLED = (WM_USER + 9),
            TB_ISBUTTONCHECKED = (WM_USER + 10),
            TB_ISBUTTONPRESSED = (WM_USER + 11),
            TB_ISBUTTONHIDDEN = (WM_USER + 12),
            TB_ISBUTTONINDETERMINATE = (WM_USER + 13),
            TB_ISBUTTONHIGHLIGHTED = (WM_USER + 14),
            TB_SETSTATE = (WM_USER + 17),
            TB_GETSTATE = (WM_USER + 18),
            TB_ADDBITMAP = (WM_USER + 19),
            TB_ADDBUTTONSA = (WM_USER + 20),
            TB_INSERTBUTTONA = (WM_USER + 21),
            TB_ADDBUTTONS = (WM_USER + 20),
            TB_INSERTBUTTON = (WM_USER + 21),
            TB_DELETEBUTTON = (WM_USER + 22),
            TB_GETBUTTON = (WM_USER + 23),
            TB_BUTTONCOUNT = (WM_USER + 24),
            TB_COMMANDTOINDEX = (WM_USER + 25),
            TB_SAVERESTOREA = (WM_USER + 26),
            TB_SAVERESTOREW = (WM_USER + 76),
            TB_CUSTOMIZE = (WM_USER + 27),
            TB_ADDSTRINGA = (WM_USER + 28),
            TB_ADDSTRINGW = (WM_USER + 77),
            TB_GETITEMRECT = (WM_USER + 29),
            TB_BUTTONSTRUCTSIZE = (WM_USER + 30),
            TB_SETBUTTONSIZE = (WM_USER + 31),
            TB_SETBITMAPSIZE = (WM_USER + 32),
            TB_AUTOSIZE = (WM_USER + 33),
            TB_GETTOOLTIPS = (WM_USER + 35),
            TB_SETTOOLTIPS = (WM_USER + 36),
            TB_SETPARENT = (WM_USER + 37),
            TB_SETROWS = (WM_USER + 39),
            TB_GETROWS = (WM_USER + 40),
            TB_SETCMDID = (WM_USER + 42),
            TB_CHANGEBITMAP = (WM_USER + 43),
            TB_GETBITMAP = (WM_USER + 44),
            TB_GETBUTTONTEXTA = (WM_USER + 45),
            TB_GETBUTTONTEXTW = (WM_USER + 75),
            TB_REPLACEBITMAP = (WM_USER + 46),
            TB_SETINDENT = (WM_USER + 47),
            TB_SETIMAGELIST = (WM_USER + 48),
            TB_GETIMAGELIST = (WM_USER + 49),
            TB_LOADIMAGES = (WM_USER + 50),
            TB_GETRECT = (WM_USER + 51),
            TB_SETHOTIMAGELIST = (WM_USER + 52),
            TB_GETHOTIMAGELIST = (WM_USER + 53),
            TB_SETDISABLEDIMAGELIST = (WM_USER + 54),
            TB_GETDISABLEDIMAGELIST = (WM_USER + 55),
            TB_SETSTYLE = (WM_USER + 56),
            TB_GETSTYLE = (WM_USER + 57),
            TB_GETBUTTONSIZE = (WM_USER + 58),
            TB_SETBUTTONWIDTH = (WM_USER + 59),
            TB_SETMAXTEXTROWS = (WM_USER + 60),
            TB_GETTEXTROWS = (WM_USER + 61),
            TB_GETOBJECT = (WM_USER + 62),
            TB_GETHOTITEM = (WM_USER + 71),
            TB_SETHOTITEM = (WM_USER + 72),
            TB_SETANCHORHIGHLIGHT = (WM_USER + 73),
            TB_GETANCHORHIGHLIGHT = (WM_USER + 74),
            TB_MAPACCELERATORA = (WM_USER + 78),
            TB_GETINSERTMARK = (WM_USER + 79),
            TB_SETINSERTMARK = (WM_USER + 80),
            TB_INSERTMARKHITTEST = (WM_USER + 81),
            TB_MOVEBUTTON = (WM_USER + 82),
            TB_GETMAXSIZE = (WM_USER + 83),
            TB_SETEXTENDEDSTYLE = (WM_USER + 84),
            TB_GETEXTENDEDSTYLE = (WM_USER + 85),
            TB_GETPADDING = (WM_USER + 86),
            TB_SETPADDING = (WM_USER + 87),
            TB_SETINSERTMARKCOLOR = (WM_USER + 88),
            TB_GETINSERTMARKCOLOR = (WM_USER + 89),
            TB_SETCOLORSCHEME = CCM_SETCOLORSCHEME,
            TB_GETCOLORSCHEME = CCM_GETCOLORSCHEME,
            TB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT,
            TB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT,
            TB_MAPACCELERATORW = (WM_USER + 90),
            TB_GETBITMAPFLAGS = (WM_USER + 41),
            TB_GETBUTTONINFOW = (WM_USER + 63),
            TB_SETBUTTONINFOW = (WM_USER + 64),
            TB_GETBUTTONINFOA = (WM_USER + 65),
            TB_SETBUTTONINFOA = (WM_USER + 66),
            TB_INSERTBUTTONW = (WM_USER + 67),
            TB_ADDBUTTONSW = (WM_USER + 68),
            TB_HITTEST = (WM_USER + 69),
            TB_SETDRAWTEXTFLAGS = (WM_USER + 70),
            TB_GETSTRINGW = (WM_USER + 91),
            TB_GETSTRINGA = (WM_USER + 92),
            TB_GETMETRICS = (WM_USER + 101),
            TB_SETMETRICS = (WM_USER + 102),
            TB_SETWINDOWTHEME = CCM_SETWINDOWTHEME,
            RB_INSERTBANDA = (WM_USER + 1),
            RB_DELETEBAND = (WM_USER + 2),
            RB_GETBARINFO = (WM_USER + 3),
            RB_SETBARINFO = (WM_USER + 4),
            RB_GETBANDINFO = (WM_USER + 5),
            RB_SETBANDINFOA = (WM_USER + 6),
            RB_SETPARENT = (WM_USER + 7),
            RB_HITTEST = (WM_USER + 8),
            RB_GETRECT = (WM_USER + 9),
            RB_INSERTBANDW = (WM_USER + 10),

            OCM_HSCROLL = 0x2114,
            OCM_VSCROLL = 0x2115,

            SC_KEYMENU = 0xF100
        }
        #endregion
    }
}
