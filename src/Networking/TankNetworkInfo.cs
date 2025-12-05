using System;
using SFIUtils.Serialization;
using SFIUtils.Serialization.Padding;

namespace ZapTank.Networking;

/// <summary>
/// Contains info required to update a given tank across networks.
/// </summary>
public class TankNetworkInfo:IBinarySerializable
{
    public PaddingInfoBase[] GetPadding()
    {
        throw new NotImplementedException();
    }

    public byte[] ToBinary()
    {
        throw new NotImplementedException();
    }

    public void InitFromBinary(byte[] bytes, PaddingInfoBase[] paddingInfoBase)
    {
        throw new NotImplementedException();
    }

    public SerializerConfig Config { get => throw new NotImplementedException(); }
}