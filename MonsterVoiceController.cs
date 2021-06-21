using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x2000219")]
public class MonsterVoiceController : CharaVoiceController<MonsterControllerBase>
{
	// Token: 0x17000310 RID: 784
	// (get) Token: 0x06001157 RID: 4439 RVA: 0x00007F68 File Offset: 0x00006168
	[Token(Token = "0x170002E6")]
	protected override CharID CharID
	{
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x1E0F250", Offset = "0x1E0F351", VA = "0x1E0F250", Slot = "22")]
		get
		{
			return CharID.ch000;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x1E0F260", Offset = "0x1E0F361", VA = "0x1E0F260")]
	public MonsterVoiceController()
	{
	}

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private CharID m_charID;
}
