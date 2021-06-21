using System;
using Il2CppDummyDll;

// Token: 0x02000197 RID: 407
[Token(Token = "0x2000142")]
public interface IBulletModule
{
	// Token: 0x06000859 RID: 2137
	[Token(Token = "0x6000729")]
	void OnSetup(BulletBase bullet);

	// Token: 0x0600085A RID: 2138
	[Token(Token = "0x600072A")]
	void OnUpdate(BulletBase bullet);

	// Token: 0x0600085B RID: 2139
	[Token(Token = "0x600072B")]
	void OnFixedUpdate(BulletBase bullet);
}
