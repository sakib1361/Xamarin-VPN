using System;
using ObjCRuntime;

[Native]
public enum OpenVPNAdapterError : nint
{
	ConfigurationFailure = 1,
	CredentialsFailure,
	NetworkRecvError,
	NetworkEOFError,
	NetworkSendError,
	NetworkUnavailable,
	DecryptError,
	HMACError,
	ReplayError,
	BufferError,
	CCError,
	BadSrcAddr,
	CompressError,
	ResolveError,
	SocketSetupFailed,
	SocketProtectError,
	TUNReadError,
	TUNWriteError,
	TUNFramingError,
	TUNSetupFailed,
	TUNIfaceCreate,
	TUNIfaceDisabled,
	TUNError,
	TUNRegisterRingsError,
	TAPNotSupported,
	RerouteGatewayNoDns,
	TransportError,
	TCPOverflow,
	TCPSizeError,
	TCPConnectError,
	UDPConnectError,
	SSLError,
	SSLPartialWrite,
	EncapsulationError,
	EPKICertError,
	EPKISignError,
	HandshakeTimeout,
	KeepaliveTimeout,
	InactiveTimeout,
	ConnectionTimeout,
	PrimaryExpire,
	TLSVersionMin,
	TLSAuthFail,
	TLSCryptMetaFail,
	CertVerifyFail,
	PEMPasswordFail,
	AuthFailed,
	ClientHalt,
	ClientRestart,
	TUNHalt,
	Relay,
	RelayError,
	PauseNumber,
	ReconnectNumber,
	KeyLimitRenegNumber,
	KeyStateError,
	ProxyError,
	ProxyNeedCreds,
	KevNegotiateError,
	KevPendingError,
	KevExpireNumber,
	PKTIDInvalid,
	PKTIDBacktrack,
	PKTIDExpire,
	PKTIDReplay,
	PKTIDTimeBacktrack,
	DynamicChallenge,
	EPKIError,
	EPKIInvalidAlias,
	Unknown
}

[Native]
public enum OpenVPNAdapterEvent : nint
{
	Disconnected,
	Connected,
	Reconnecting,
	AuthPending,
	Resolve,
	Wait,
	WaitProxy,
	Connecting,
	GetConfig,
	AssignIP,
	AddRoutes,
	Echo,
	Info,
	Warn,
	Pause,
	Resume,
	Relay,
	CompressionEnabled,
	UnsupportedFeature,
	Unknown
}

[Native]
public enum OpenVPNTransportProtocol : nint
{
	Udp,
	Tcp,
	Adaptive,
	Default
}

[Native]
public enum OpenVPNIPv6Preference : nint
{
	Enabled,
	Disabled,
	Default
}

[Native]
public enum OpenVPNCompressionMode : nint
{
	Enabled,
	Disabled,
	Asym,
	Default
}

[Native]
public enum OpenVPNMinTLSVersion : nint
{
	Disabled,
	OpenVPNMinTLSVersion10,
	OpenVPNMinTLSVersion11,
	OpenVPNMinTLSVersion12,
	Default
}

[Native]
public enum OpenVPNTLSCertProfile : nint
{
	Legacy,
	Preferred,
	SuiteB,
	LegacyDefault,
	PreferredDefault,
	Default
}

[Native]
public enum OpenVPNKeyType : nint
{
	None = 0,
	Rsa,
	Eckey,
	Eckeydh,
	Ecdsa,
	Rsaalt,
	Rsassapss
}

[Native]
public enum OpenVPNReachabilityStatus : nint
{
	NotReachable,
	ReachableViaWiFi,
	ReachableViaWWAN
}
