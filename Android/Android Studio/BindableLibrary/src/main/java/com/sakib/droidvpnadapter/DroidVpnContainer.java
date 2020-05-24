package com.sakib.droidvpnadapter;

import net.openvpn.ovpn3.ClientAPI_OpenVPNClient;

public class DroidVpnContainer extends ClientAPI_OpenVPNClient {
    final static long EmulateExcludeRoutes = (1 << 16);

    static {
        System.loadLibrary("ovpn3");
    }
}
