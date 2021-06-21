using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B32 RID: 2866
[Token(Token = "0x200077C")]
public interface GrapInterface
{
	// Token: 0x170009CF RID: 2511
	// (get) Token: 0x060049FA RID: 18938
	[Token(Token = "0x170007D1")]
	Collider Collider { [Token(Token = "0x6003DEC")] get; }

	// Token: 0x060049FB RID: 18939
	[Token(Token = "0x6003DED")]
	bool CanGrap(HumanController humanController);

	// Token: 0x060049FC RID: 18940
	[Token(Token = "0x6003DEE")]
	bool DoGrap(HumanController humanController);

	// Token: 0x060049FD RID: 18941
	[Token(Token = "0x6003DEF")]
	bool OnThrow(Vector3 direction, float power);

	// Token: 0x060049FE RID: 18942
	[Token(Token = "0x6003DF0")]
	bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo);

	// Token: 0x060049FF RID: 18943
	[Token(Token = "0x6003DF1")]
	bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo1, DamageInfo damageInfo2);

	// Token: 0x06004A00 RID: 18944
	[Token(Token = "0x6003DF2")]
	bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult);

	// Token: 0x06004A01 RID: 18945
	[Token(Token = "0x6003DF3")]
	void UpdatePosition(Vector3 grappler, Vector3 foward, float rate);

	// Token: 0x170009D0 RID: 2512
	// (get) Token: 0x06004A02 RID: 18946
	[Token(Token = "0x170007D2")]
	Vector3 CurrentPosition { [Token(Token = "0x6003DF4")] get; }
}
