using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000616 RID: 1558
[Token(Token = "0x2000463")]
public interface FocusInterface
{
	// Token: 0x06002678 RID: 9848
	[Token(Token = "0x6002078")]
	string GetFocusName();

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x06002679 RID: 9849
	[Token(Token = "0x170004ED")]
	bool Focusable { [Token(Token = "0x6002079")] get; }

	// Token: 0x0600267A RID: 9850
	[Token(Token = "0x600207A")]
	void OnFocus();

	// Token: 0x0600267B RID: 9851
	[Token(Token = "0x600207B")]
	void OffFocus();

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x0600267C RID: 9852
	[Token(Token = "0x170004EE")]
	FocusObjectType FocusObjectType { [Token(Token = "0x600207C")] get; }

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x0600267D RID: 9853
	[Token(Token = "0x170004EF")]
	int FocusPriority { [Token(Token = "0x600207D")] get; }

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x0600267E RID: 9854
	[Token(Token = "0x170004F0")]
	FocusPointType FocusPointType { [Token(Token = "0x600207E")] get; }

	// Token: 0x0600267F RID: 9855
	[Token(Token = "0x600207F")]
	ushort GetInteractionType();

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x06002680 RID: 9856
	[Token(Token = "0x170004F1")]
	GameObject gameObject { [Token(Token = "0x6002080")] get; }

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x06002681 RID: 9857
	[Token(Token = "0x170004F2")]
	Transform transform { [Token(Token = "0x6002081")] get; }
}
