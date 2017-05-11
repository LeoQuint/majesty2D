using System;

namespace NSP_Game {

    [Serializable]
    public struct TileLayer
    {
        
        public ESubGroundLayer subGroundLayer;
        [EnumFlag]
        public ESubGroundLayerModifiers subGroundLayerModifiers;
        
        public EGroundLayer groundLayer;
        [EnumFlag]
        public EGroundLayerModifiers groundLayerModifiers;
        
        public EObjectLayer objectLayer;
        [EnumFlag]
        public EObjectLayerModifiers objectLayerModifiers;
        
        public EAirLayer airLayer;
        [EnumFlag]
        public EAirLayerModifiers airLayerModifiers;
    }
    

    public static class Extensions
    {
        public static bool HasFlag(this ESubGroundLayer layer, ESubGroundLayer values)
        {
            bool isTrue = false;
            if ((layer & values) != 0)
            {
                isTrue = true;
            } 
            return isTrue;
        }
        public static bool HasFlag(this EGroundLayer layer, EGroundLayer values)
        {
            bool isTrue = false;
            if ((layer & values) != 0)
            {
                isTrue = true;
            }
            return isTrue;
        }
        public static bool HasFlag(this EObjectLayer layer, EObjectLayer values)
        {
            bool isTrue = false;
            if ((layer & values) != 0)
            {
                isTrue = true;
            }
            return isTrue;
        }
        public static bool HasFlag(this EAirLayer layer, EAirLayer values)
        {
            bool isTrue = false;
            if ((layer & values) != 0)
            {
                isTrue = true;
            }
            return isTrue;
        }
    }

    #region Layer Enums

    public enum ESubGroundLayer
    {
        //Debugs
        ERROR = 0,
        //rename when in use:
        DEBUG = 1,
        TYPE2 = 2,
        TYPE3 = 3,
        TYPE4 = 4,
        TYPE5 = 5,
        TYPE6 = 6,
        TYPE7 = 7,
        TYPE8 = 8,
        TYPE9 = 9

    }

    public enum ESubGroundLayerModifiers
    {
        //Debugs
        ERROR = 0,
        WARNING = 1,
        DEBUG1 = 2,
        DEBUG2 = 4,
        DEBUG3 = 8,
        //types : Rename when in use
        TYPE1 = 16,
        TYPE2 = 32,
        TYPE3 = 64,
        TYPE4 = 128,
        TYPE5 = 256,
        TYPE6 = 512,
        TYPE7 = 1024,
        TYPE8 = 2048,
        TYPE9 = 4096,
        TYPE10 = 8192,
        TYPE11 = 16384,
        TYPE12 = 32768,
        TYPE13 = 65536,
        TYPE14 = 131072,
        TYPE15 = 262144,
        TYPE16 = 524288,
        TYPE17 = 1048576,
        TYPE18 = 2097152,
        //Modifiers : Rename when in use
        MOD1 = 4194304,
        MOD2 = 8388608,
        MOD3 = 16777216,
        MOD4 = 33554432,
        MOD5 = 67108864,
        MOD6 = 134217728,
        MOD7 = 268435456,
        MOD8 = 536870912,
        MOD9 = 1073741824
    }

    public enum EGroundLayer
    {
        //Debugs
        ERROR = 0,
        //rename when in use:
        DEBUG = 1,
        Dirt1 = 2,
        TYPE3 = 3,
        TYPE4 = 4,
        TYPE5 = 5,
        TYPE6 = 6,
        TYPE7 = 7,
        TYPE8 = 8,
        TYPE9 = 9

    }

    public enum EGroundLayerModifiers
    {
        //Debugs
        ERROR = 0,
        WARNING = 1,
        DEBUG1 = 2,
        DEBUG2 = 4,
        DEBUG3 = 8,
        //types : Rename when in use
        TYPE1 = 16,
        TYPE2 = 32,
        TYPE3 = 64,
        TYPE4 = 128,
        TYPE5 = 256,
        TYPE6 = 512,
        TYPE7 = 1024,
        TYPE8 = 2048,
        TYPE9 = 4096,
        TYPE10 = 8192,
        TYPE11 = 16384,
        TYPE12 = 32768,
        TYPE13 = 65536,
        TYPE14 = 131072,
        TYPE15 = 262144,
        TYPE16 = 524288,
        TYPE17 = 1048576,
        TYPE18 = 2097152,
        //Modifiers : Rename when in use
        MOD1 = 4194304,
        MOD2 = 8388608,
        MOD3 = 16777216,
        MOD4 = 33554432,
        MOD5 = 67108864,
        MOD6 = 134217728,
        MOD7 = 268435456,
        MOD8 = 536870912,
        MOD9 = 1073741824
    }

    public enum EObjectLayer
    {
        //Debugs
        ERROR = 0,
        //rename when in use:
        DEBUG = 1,
        TYPE2 = 2,
        TYPE3 = 3,
        TYPE4 = 4,
        TYPE5 = 5,
        TYPE6 = 6,
        TYPE7 = 7,
        TYPE8 = 8,
        TYPE9 = 9

    }
    
    public enum EObjectLayerModifiers
    {
        //Debugs
        ERROR = 0,
        WARNING = 1,
        DEBUG1 = 2,
        DEBUG2 = 4,
        DEBUG3 = 8,
        //types : Rename when in use
        TYPE1 = 16,
        TYPE2 = 32,
        TYPE3 = 64,
        TYPE4 = 128,
        TYPE5 = 256,
        TYPE6 = 512,
        TYPE7 = 1024,
        TYPE8 = 2048,
        TYPE9 = 4096,
        TYPE10 = 8192,
        TYPE11 = 16384,
        TYPE12 = 32768,
        TYPE13 = 65536,
        TYPE14 = 131072,
        TYPE15 = 262144,
        TYPE16 = 524288,
        TYPE17 = 1048576,
        TYPE18 = 2097152,
        //Modifiers : Rename when in use
        MOD1 = 4194304,
        MOD2 = 8388608,
        MOD3 = 16777216,
        MOD4 = 33554432,
        MOD5 = 67108864,
        MOD6 = 134217728,
        MOD7 = 268435456,
        MOD8 = 536870912,
        MOD9 = 1073741824
    }

    public enum EAirLayer
    {
        //Debugs
        ERROR = 0,
        //rename when in use:
        DEBUG = 1,
        TYPE2 = 2,
        TYPE3 = 3,
        TYPE4 = 4,
        TYPE5 = 5,
        TYPE6 = 6,
        TYPE7 = 7,
        TYPE8 = 8,
        TYPE9 = 9

    }

    public enum EAirLayerModifiers
    {
        //Debugs
        ERROR = 0,
        WARNING = 1,
        DEBUG1 = 2,
        DEBUG2 = 4,
        DEBUG3 = 8,
        //types : Rename when in use
        TYPE1 = 16,
        TYPE2 = 32,
        TYPE3 = 64,
        TYPE4 = 128,
        TYPE5 = 256,
        TYPE6 = 512,
        TYPE7 = 1024,
        TYPE8 = 2048,
        TYPE9 = 4096,
        TYPE10 = 8192,
        TYPE11 = 16384,
        TYPE12 = 32768,
        TYPE13 = 65536,
        TYPE14 = 131072,
        TYPE15 = 262144,
        TYPE16 = 524288,
        TYPE17 = 1048576,
        TYPE18 = 2097152,
        //Modifiers : Rename when in use
        MOD1 = 4194304,
        MOD2 = 8388608,
        MOD3 = 16777216,
        MOD4 = 33554432,
        MOD5 = 67108864,
        MOD6 = 134217728,
        MOD7 = 268435456,
        MOD8 = 536870912,
        MOD9 = 1073741824
    }
    #endregion
    }
