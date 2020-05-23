using System;
using Foundation;
using NetworkExtension;
using ObjCRuntime;
using OpenVPNAdapter;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double OpenVPNAdapterVersionNumber;
	[Field ("OpenVPNAdapterVersionNumber", "__Internal")]
	double OpenVPNAdapterVersionNumber { get; }

	// extern const unsigned char [] OpenVPNAdapterVersionString;
	[Field ("OpenVPNAdapterVersionString", "__Internal")]
	byte[] OpenVPNAdapterVersionString { get; }

	// extern NSString *const _Nonnull OpenVPNAdapterErrorDomain;
	[Field ("OpenVPNAdapterErrorDomain", "__Internal")]
	NSString OpenVPNAdapterErrorDomain { get; }

	// extern NSString *const _Nonnull OpenVPNIdentityErrorDomain;
	[Field ("OpenVPNIdentityErrorDomain", "__Internal")]
	NSString OpenVPNIdentityErrorDomain { get; }

	// extern NSString *const _Nonnull OpenVPNAdapterErrorFatalKey;
	[Field ("OpenVPNAdapterErrorFatalKey", "__Internal")]
	NSString OpenVPNAdapterErrorFatalKey { get; }

	// extern NSString *const _Nonnull OpenVPNAdapterErrorMessageKey;
	[Field ("OpenVPNAdapterErrorMessageKey", "__Internal")]
	NSString OpenVPNAdapterErrorMessageKey { get; }
}

// @interface OpenVPNConfiguration : NSObject <NSCopying, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface OpenVPNConfiguration : INSCopying, INSSecureCoding
{
	// @property (nonatomic) NSData * _Nullable fileContent;
	[NullAllowed, Export ("fileContent", ArgumentSemantic.Assign)]
	NSData FileContent { get; set; }

	// @property (nonatomic) NSDictionary<NSString *,NSString *> * _Nullable settings;
	[NullAllowed, Export ("settings", ArgumentSemantic.Assign)]
	NSDictionary<NSString, NSString> Settings { get; set; }

	// @property (nonatomic) NSString * _Nullable guiVersion;
	[NullAllowed, Export ("guiVersion")]
	string GuiVersion { get; set; }

	// @property (nonatomic) NSString * _Nullable ssoMethods;
	[NullAllowed, Export ("ssoMethods")]
	string SsoMethods { get; set; }

	// @property (nonatomic) NSString * _Nullable hardwareAdressOverride;
	[NullAllowed, Export ("hardwareAdressOverride")]
	string HardwareAdressOverride { get; set; }

	// @property (nonatomic) NSString * _Nullable platformVersion;
	[NullAllowed, Export ("platformVersion")]
	string PlatformVersion { get; set; }

	// @property (nonatomic) NSString * _Nullable server;
	[NullAllowed, Export ("server")]
	string Server { get; set; }

	// @property (nonatomic) NSUInteger port;
	[Export ("port")]
	nuint Port { get; set; }

	// @property (nonatomic) OpenVPNTransportProtocol proto;
	[Export ("proto", ArgumentSemantic.Assign)]
	OpenVPNTransportProtocol Proto { get; set; }

	// @property (nonatomic) OpenVPNIPv6Preference ipv6;
	[Export ("ipv6", ArgumentSemantic.Assign)]
	OpenVPNIPv6Preference Ipv6 { get; set; }

	// @property (nonatomic) NSInteger connectionTimeout;
	[Export ("connectionTimeout")]
	nint ConnectionTimeout { get; set; }

	// @property (nonatomic) BOOL tunPersist;
	[Export ("tunPersist")]
	bool TunPersist { get; set; }

	// @property (nonatomic) BOOL googleDNSFallback;
	[Export ("googleDNSFallback")]
	bool GoogleDNSFallback { get; set; }

	// @property (nonatomic) BOOL synchronousDNSLookup;
	[Export ("synchronousDNSLookup")]
	bool SynchronousDNSLookup { get; set; }

	// @property (nonatomic) BOOL autologinSessions;
	[Export ("autologinSessions")]
	bool AutologinSessions { get; set; }

	// @property (nonatomic) BOOL retryOnAuthFailed;
	[Export ("retryOnAuthFailed")]
	bool RetryOnAuthFailed { get; set; }

	// @property (nonatomic) BOOL disableClientCert;
	[Export ("disableClientCert")]
	bool DisableClientCert { get; set; }

	// @property (nonatomic) NSInteger sslDebugLevel;
	[Export ("sslDebugLevel")]
	nint SslDebugLevel { get; set; }

	// @property (nonatomic) OpenVPNCompressionMode compressionMode;
	[Export ("compressionMode", ArgumentSemantic.Assign)]
	OpenVPNCompressionMode CompressionMode { get; set; }

	// @property (nonatomic) NSString * _Nullable privateKeyPassword;
	[NullAllowed, Export ("privateKeyPassword")]
	string PrivateKeyPassword { get; set; }

	// @property (nonatomic) NSInteger keyDirection;
	[Export ("keyDirection")]
	nint KeyDirection { get; set; }

	// @property (nonatomic) BOOL forceCiphersuitesAESCBC;
	[Export ("forceCiphersuitesAESCBC")]
	bool ForceCiphersuitesAESCBC { get; set; }

	// @property (nonatomic) OpenVPNMinTLSVersion minTLSVersion;
	[Export ("minTLSVersion", ArgumentSemantic.Assign)]
	OpenVPNMinTLSVersion MinTLSVersion { get; set; }

	// @property (nonatomic) OpenVPNTLSCertProfile tlsCertProfile;
	[Export ("tlsCertProfile", ArgumentSemantic.Assign)]
	OpenVPNTLSCertProfile TlsCertProfile { get; set; }

	// @property (nonatomic) NSDictionary<NSString *,NSString *> * _Nullable peerInfo;
	[NullAllowed, Export ("peerInfo", ArgumentSemantic.Assign)]
	NSDictionary<NSString, NSString> PeerInfo { get; set; }

	// @property (nonatomic) BOOL echo;
	[Export ("echo")]
	bool Echo { get; set; }

	// @property (nonatomic) BOOL info;
	[Export ("info")]
	bool Info { get; set; }

	// @property (nonatomic) NSUInteger clockTick;
	[Export ("clockTick")]
	nuint ClockTick { get; set; }
}

// @interface OpenVPNCredentials : NSObject
[BaseType (typeof(NSObject))]
interface OpenVPNCredentials
{
	// @property (nonatomic) NSString * _Nullable username;
	[NullAllowed, Export ("username")]
	string Username { get; set; }

	// @property (nonatomic) NSString * _Nullable password;
	[NullAllowed, Export ("password")]
	string Password { get; set; }

	// @property (nonatomic) NSString * _Nullable response;
	[NullAllowed, Export ("response")]
	string Response { get; set; }

	// @property (nonatomic) NSString * _Nullable dynamicChallengeCookie;
	[NullAllowed, Export ("dynamicChallengeCookie")]
	string DynamicChallengeCookie { get; set; }

	// @property (nonatomic) BOOL replacePasswordWithSessionID;
	[Export ("replacePasswordWithSessionID")]
	bool ReplacePasswordWithSessionID { get; set; }

	// @property (nonatomic) BOOL cachePassword;
	[Export ("cachePassword")]
	bool CachePassword { get; set; }
}

// @interface OpenVPNServerEntry : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface OpenVPNServerEntry
{
	// @property (readonly, nonatomic) NSString * _Nullable server;
	[NullAllowed, Export ("server")]
	string Server { get; }

	// @property (readonly, nonatomic) NSString * _Nullable friendlyName;
	[NullAllowed, Export ("friendlyName")]
	string FriendlyName { get; }
}

// @interface OpenVPNProperties : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface OpenVPNProperties
{
	// @property (readonly, nonatomic) NSString * _Nullable username;
	[NullAllowed, Export ("username")]
	string Username { get; }

	// @property (readonly, nonatomic) NSString * _Nullable profileName;
	[NullAllowed, Export ("profileName")]
	string ProfileName { get; }

	// @property (readonly, nonatomic) NSString * _Nullable friendlyName;
	[NullAllowed, Export ("friendlyName")]
	string FriendlyName { get; }

	// @property (readonly, nonatomic) BOOL autologin;
	[Export ("autologin")]
	bool Autologin { get; }

	// @property (readonly, nonatomic) NSString * _Nullable staticChallenge;
	[NullAllowed, Export ("staticChallenge")]
	string StaticChallenge { get; }

	// @property (readonly, nonatomic) BOOL staticChallengeEcho;
	[Export ("staticChallengeEcho")]
	bool StaticChallengeEcho { get; }

	// @property (readonly, getter = isPrivateKeyPasswordRequired, nonatomic) BOOL privateKeyPasswordRequired;
	[Export ("privateKeyPasswordRequired")]
	bool PrivateKeyPasswordRequired { [Bind ("isPrivateKeyPasswordRequired")] get; }

	// @property (readonly, nonatomic) BOOL allowPasswordSave;
	[Export ("allowPasswordSave")]
	bool AllowPasswordSave { get; }

	// @property (readonly, nonatomic) NSString * _Nullable remoteHost;
	[NullAllowed, Export ("remoteHost")]
	string RemoteHost { get; }

	// @property (readonly, nonatomic) NSUInteger remotePort;
	[Export ("remotePort")]
	nuint RemotePort { get; }

	// @property (readonly, nonatomic) OpenVPNTransportProtocol remoteProto;
	[Export ("remoteProto")]
	OpenVPNTransportProtocol RemoteProto { get; }

	// @property (readonly, nonatomic) NSArray<OpenVPNServerEntry *> * _Nullable servers;
	[NullAllowed, Export ("servers")]
	OpenVPNServerEntry[] Servers { get; }
}

// @interface OpenVPNConnectionInfo : NSObject <NSCopying, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface OpenVPNConnectionInfo : INSCopying, INSSecureCoding
{
	// @property (readonly, nonatomic) NSString * _Nullable user;
	[NullAllowed, Export ("user")]
	string User { get; }

	// @property (readonly, nonatomic) NSString * _Nullable serverHost;
	[NullAllowed, Export ("serverHost")]
	string ServerHost { get; }

	// @property (readonly, nonatomic) NSString * _Nullable serverPort;
	[NullAllowed, Export ("serverPort")]
	string ServerPort { get; }

	// @property (readonly, nonatomic) NSString * _Nullable serverProto;
	[NullAllowed, Export ("serverProto")]
	string ServerProto { get; }

	// @property (readonly, nonatomic) NSString * _Nullable serverIP;
	[NullAllowed, Export ("serverIP")]
	string ServerIP { get; }

	// @property (readonly, nonatomic) NSString * _Nullable vpnIPv4;
	[NullAllowed, Export ("vpnIPv4")]
	string VpnIPv4 { get; }

	// @property (readonly, nonatomic) NSString * _Nullable vpnIPv6;
	[NullAllowed, Export ("vpnIPv6")]
	string VpnIPv6 { get; }

	// @property (readonly, nonatomic) NSString * _Nullable gatewayIPv4;
	[NullAllowed, Export ("gatewayIPv4")]
	string GatewayIPv4 { get; }

	// @property (readonly, nonatomic) NSString * _Nullable gatewayIPv6;
	[NullAllowed, Export ("gatewayIPv6")]
	string GatewayIPv6 { get; }

	// @property (readonly, nonatomic) NSString * _Nullable clientIP;
	[NullAllowed, Export ("clientIP")]
	string ClientIP { get; }

	// @property (readonly, nonatomic) NSString * _Nullable tunName;
	[NullAllowed, Export ("tunName")]
	string TunName { get; }
}

// @interface OpenVPNSessionToken : NSObject <NSCopying, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface OpenVPNSessionToken : INSCopying, INSSecureCoding
{
	// @property (readonly, nonatomic) NSString * _Nullable username;
	[NullAllowed, Export ("username")]
	string Username { get; }

	// @property (readonly, nonatomic) NSString * _Nullable session;
	[NullAllowed, Export ("session")]
	string Session { get; }
}

// @interface OpenVPNTransportStats : NSObject <NSCopying, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface OpenVPNTransportStats : INSCopying, INSSecureCoding
{
	// @property (readonly, nonatomic) NSInteger bytesIn;
	[Export ("bytesIn")]
	nint BytesIn { get; }

	// @property (readonly, nonatomic) NSInteger bytesOut;
	[Export ("bytesOut")]
	nint BytesOut { get; }

	// @property (readonly, nonatomic) NSInteger packetsIn;
	[Export ("packetsIn")]
	nint PacketsIn { get; }

	// @property (readonly, nonatomic) NSInteger packetsOut;
	[Export ("packetsOut")]
	nint PacketsOut { get; }

	// @property (readonly, nonatomic) NSDate * _Nullable lastPacketReceived;
	[NullAllowed, Export ("lastPacketReceived")]
	NSDate LastPacketReceived { get; }
}

// @interface OpenVPNInterfaceStats : NSObject <NSCopying, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface OpenVPNInterfaceStats : INSCopying, INSSecureCoding
{
	// @property (readonly, nonatomic) NSInteger bytesIn;
	[Export ("bytesIn")]
	nint BytesIn { get; }

	// @property (readonly, nonatomic) NSInteger bytesOut;
	[Export ("bytesOut")]
	nint BytesOut { get; }

	// @property (readonly, nonatomic) NSInteger packetsIn;
	[Export ("packetsIn")]
	nint PacketsIn { get; }

	// @property (readonly, nonatomic) NSInteger packetsOut;
	[Export ("packetsOut")]
	nint PacketsOut { get; }

	// @property (readonly, nonatomic) NSInteger errorsIn;
	[Export ("errorsIn")]
	nint ErrorsIn { get; }

	// @property (readonly, nonatomic) NSInteger errorsOut;
	[Export ("errorsOut")]
	nint ErrorsOut { get; }
}

// @protocol OpenVPNAdapterDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface OpenVPNAdapterDelegate
{
	// @required -(void)openVPNAdapter:(OpenVPNAdapter * _Nonnull)openVPNAdapter configureTunnelWithNetworkSettings:(NEPacketTunnelNetworkSettings * _Nullable)networkSettings completionHandler:(void (^ _Nonnull)(id<OpenVPNAdapterPacketFlow> _Nullable))completionHandler;
	[Abstract]
	[Export ("openVPNAdapter:configureTunnelWithNetworkSettings:completionHandler:")]
	void OpenVPNAdapter (OpenVPNAdapter openVPNAdapter, [NullAllowed] NEPacketTunnelNetworkSettings networkSettings, Action<OpenVPNAdapterPacketFlow> completionHandler);

	// @required -(void)openVPNAdapter:(OpenVPNAdapter * _Nonnull)openVPNAdapter handleError:(NSError * _Nonnull)error;
	[Abstract]
	[Export ("openVPNAdapter:handleError:")]
	void OpenVPNAdapter (OpenVPNAdapter openVPNAdapter, NSError error);

	// @required -(void)openVPNAdapter:(OpenVPNAdapter * _Nonnull)openVPNAdapter handleEvent:(OpenVPNAdapterEvent)event message:(NSString * _Nullable)message;
	[Abstract]
	[Export ("openVPNAdapter:handleEvent:message:")]
	void OpenVPNAdapter (OpenVPNAdapter openVPNAdapter, OpenVPNAdapterEvent @event, [NullAllowed] string message);

	// @optional -(void)openVPNAdapter:(OpenVPNAdapter * _Nonnull)openVPNAdapter handleLogMessage:(NSString * _Nonnull)logMessage;
	[Export ("openVPNAdapter:handleLogMessage:")]
	void OpenVPNAdapter (OpenVPNAdapter openVPNAdapter, string logMessage);

	// @optional -(void)openVPNAdapterDidReceiveClockTick:(OpenVPNAdapter * _Nonnull)openVPNAdapter;
	[Export ("openVPNAdapterDidReceiveClockTick:")]
	void OpenVPNAdapterDidReceiveClockTick (OpenVPNAdapter openVPNAdapter);
}

// @interface OpenVPNAdapter : NSObject
[BaseType (typeof(NSObject))]
interface OpenVPNAdapter
{
	// @property (readonly, nonatomic, class) NSString * _Nonnull copyright;
	[Static]
	[Export ("copyright")]
	string Copyright { get; }

	// @property (readonly, nonatomic, class) NSString * _Nonnull platform;
	[Static]
	[Export ("platform")]
	string Platform { get; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	OpenVPNAdapterDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<OpenVPNAdapterDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic) NSString * _Nullable sessionName;
	[NullAllowed, Export ("sessionName")]
	string SessionName { get; }

	// @property (readonly, nonatomic) OpenVPNConnectionInfo * _Nullable connectionInformation;
	[NullAllowed, Export ("connectionInformation")]
	OpenVPNConnectionInfo ConnectionInformation { get; }

	// @property (readonly, nonatomic) OpenVPNInterfaceStats * _Nonnull interfaceStatistics;
	[Export ("interfaceStatistics")]
	OpenVPNInterfaceStats InterfaceStatistics { get; }

	// @property (readonly, nonatomic) OpenVPNSessionToken * _Nullable sessionToken;
	[NullAllowed, Export ("sessionToken")]
	OpenVPNSessionToken SessionToken { get; }

	// @property (readonly, nonatomic) OpenVPNTransportStats * _Nonnull transportStatistics;
	[Export ("transportStatistics")]
	OpenVPNTransportStats TransportStatistics { get; }

	// -(OpenVPNProperties * _Nullable)applyConfiguration:(OpenVPNConfiguration * _Nonnull)configuration error:(NSError * _Nullable * _Nullable)error;
	[Export ("applyConfiguration:error:")]
	[return: NullAllowed]
	OpenVPNProperties ApplyConfiguration (OpenVPNConfiguration configuration, [NullAllowed] out NSError error);

	// -(BOOL)provideCredentials:(OpenVPNCredentials * _Nonnull)credentials error:(NSError * _Nullable * _Nullable)error;
	[Export ("provideCredentials:error:")]
	bool ProvideCredentials (OpenVPNCredentials credentials, [NullAllowed] out NSError error);

	// -(void)connect;
	[Export ("connect")]
	void Connect ();

	// -(void)pauseWithReason:(NSString * _Nonnull)reason;
	[Export ("pauseWithReason:")]
	void PauseWithReason (string reason);

	// -(void)resume;
	[Export ("resume")]
	void Resume ();

	// -(void)reconnectAfterTimeInterval:(NSTimeInterval)timeInterval;
	[Export ("reconnectAfterTimeInterval:")]
	void ReconnectAfterTimeInterval (double timeInterval);

	// -(void)disconnect;
	[Export ("disconnect")]
	void Disconnect ();
}

// @protocol OpenVPNAdapterPacketFlow <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface OpenVPNAdapterPacketFlow
{
	// @required -(void)readPacketsWithCompletionHandler:(void (^ _Nonnull)(NSArray<NSData *> * _Nonnull, NSArray<NSNumber *> * _Nonnull))completionHandler;
	[Abstract]
	[Export ("readPacketsWithCompletionHandler:")]
	void ReadPacketsWithCompletionHandler (Action<NSArray<NSData>, NSArray<NSNumber>> completionHandler);

	// @required -(BOOL)writePackets:(NSArray<NSData *> * _Nonnull)packets withProtocols:(NSArray<NSNumber *> * _Nonnull)protocols;
	[Abstract]
	[Export ("writePackets:withProtocols:")]
	bool WritePackets (NSData[] packets, NSNumber[] protocols);
}

// @interface OpenVPNCertificate : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface OpenVPNCertificate
{
	// +(OpenVPNCertificate * _Nullable)certificateWithPEM:(NSData * _Nonnull)pemData error:(NSError * _Nullable * _Nullable)error;
	[Static]
	[Export ("certificateWithPEM:error:")]
	[return: NullAllowed]
	OpenVPNCertificate CertificateWithPEM (NSData pemData, [NullAllowed] out NSError error);

	// +(OpenVPNCertificate * _Nullable)certificateWithDER:(NSData * _Nonnull)derData error:(NSError * _Nullable * _Nullable)error;
	[Static]
	[Export ("certificateWithDER:error:")]
	[return: NullAllowed]
	OpenVPNCertificate CertificateWithDER (NSData derData, [NullAllowed] out NSError error);

	// @property (readonly, nonatomic) NSInteger version;
	[Export ("version")]
	nint Version { get; }

	// @property (readonly, nonatomic) NSData * _Nonnull serial;
	[Export ("serial")]
	NSData Serial { get; }

	// @property (readonly, nonatomic) NSData * _Nonnull issuer;
	[Export ("issuer")]
	NSData Issuer { get; }

	// @property (readonly, nonatomic) NSData * _Nonnull subject;
	[Export ("subject")]
	NSData Subject { get; }

	// -(NSData * _Nullable)pemData:(NSError * _Nullable * _Nullable)error;
	[Export ("pemData:")]
	[return: NullAllowed]
	NSData PemData ([NullAllowed] out NSError error);

	// -(NSData * _Nullable)derData:(NSError * _Nullable * _Nullable)error;
	[Export ("derData:")]
	[return: NullAllowed]
	NSData DerData ([NullAllowed] out NSError error);
}

// @interface OpenVPNPrivateKey : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface OpenVPNPrivateKey
{
	// +(OpenVPNPrivateKey * _Nullable)keyWithPEM:(NSData * _Nonnull)pemData password:(NSString * _Nullable)password error:(NSError * _Nullable * _Nullable)error;
	[Static]
	[Export ("keyWithPEM:password:error:")]
	[return: NullAllowed]
	OpenVPNPrivateKey KeyWithPEM (NSData pemData, [NullAllowed] string password, [NullAllowed] out NSError error);

	// +(OpenVPNPrivateKey * _Nullable)keyWithDER:(NSData * _Nonnull)derData password:(NSString * _Nullable)password error:(NSError * _Nullable * _Nullable)error;
	[Static]
	[Export ("keyWithDER:password:error:")]
	[return: NullAllowed]
	OpenVPNPrivateKey KeyWithDER (NSData derData, [NullAllowed] string password, [NullAllowed] out NSError error);

	// @property (readonly, nonatomic) NSInteger size;
	[Export ("size")]
	nint Size { get; }

	// @property (readonly, nonatomic) OpenVPNKeyType type;
	[Export ("type")]
	OpenVPNKeyType Type { get; }

	// -(NSData * _Nullable)pemData:(NSError * _Nullable * _Nullable)error;
	[Export ("pemData:")]
	[return: NullAllowed]
	NSData PemData ([NullAllowed] out NSError error);

	// -(NSData * _Nullable)derData:(NSError * _Nullable * _Nullable)error;
	[Export ("derData:")]
	[return: NullAllowed]
	NSData DerData ([NullAllowed] out NSError error);
}

// @interface OpenVPNReachability : NSObject
[BaseType (typeof(NSObject))]
interface OpenVPNReachability
{
	// @property (readonly, getter = isTracking, nonatomic) BOOL tracking;
	[Export ("tracking")]
	bool Tracking { [Bind ("isTracking")] get; }

	// @property (readonly, nonatomic) OpenVPNReachabilityStatus reachabilityStatus;
	[Export ("reachabilityStatus")]
	OpenVPNReachabilityStatus ReachabilityStatus { get; }

	// -(void)startTrackingWithCallback:(void (^ _Nonnull)(OpenVPNReachabilityStatus))callback;
	[Export ("startTrackingWithCallback:")]
	void StartTrackingWithCallback (Action<OpenVPNReachabilityStatus> callback);

	// -(void)stopTracking;
	[Export ("stopTracking")]
	void StopTracking ();
}
