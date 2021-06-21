using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B9 RID: 2489
[Token(Token = "0x2000684")]
public class HUDPlayerBuffIcon : MonoBehaviour
{
	// Token: 0x06004109 RID: 16649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600363C")]
	[Address(RVA = "0x2058D60", Offset = "0x2058E61", VA = "0x2058D60")]
	private void Start()
	{
	}

	// Token: 0x0600410A RID: 16650 RVA: 0x00015F18 File Offset: 0x00014118
	[Token(Token = "0x600363D")]
	[Address(RVA = "0x2058F40", Offset = "0x2059041", VA = "0x2058F40")]
	private bool CheckOnFoodBuff()
	{
		return default(bool);
	}

	// Token: 0x0600410B RID: 16651 RVA: 0x00015F30 File Offset: 0x00014130
	[Token(Token = "0x600363E")]
	[Address(RVA = "0x20590D0", Offset = "0x20591D1", VA = "0x20590D0")]
	private bool CheckOnOnsenBuff()
	{
		return default(bool);
	}

	// Token: 0x0600410C RID: 16652 RVA: 0x00015F48 File Offset: 0x00014148
	[Token(Token = "0x600363F")]
	[Address(RVA = "0x2059260", Offset = "0x2059361", VA = "0x2059260")]
	private bool CheckOnVacBuff()
	{
		return default(bool);
	}

	// Token: 0x0600410D RID: 16653 RVA: 0x00015F60 File Offset: 0x00014160
	[Token(Token = "0x6003640")]
	[Address(RVA = "0x20594E0", Offset = "0x20595E1", VA = "0x20594E0")]
	private bool CheckOnHandCuff()
	{
		return default(bool);
	}

	// Token: 0x0600410E RID: 16654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003641")]
	[Address(RVA = "0x20596D0", Offset = "0x20597D1", VA = "0x20596D0")]
	private void SetDispFood()
	{
	}

	// Token: 0x0600410F RID: 16655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003642")]
	[Address(RVA = "0x20597C0", Offset = "0x20598C1", VA = "0x20597C0")]
	private void SetDispOnsen()
	{
	}

	// Token: 0x06004110 RID: 16656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003643")]
	[Address(RVA = "0x2059870", Offset = "0x2059971", VA = "0x2059870")]
	private void SetDispVac()
	{
	}

	// Token: 0x06004111 RID: 16657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003644")]
	[Address(RVA = "0x2059920", Offset = "0x2059A21", VA = "0x2059920")]
	private void SetDispHandcuff()
	{
	}

	// Token: 0x06004112 RID: 16658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003645")]
	[Address(RVA = "0x20599C0", Offset = "0x2059AC1", VA = "0x20599C0")]
	private void Update()
	{
	}

	// Token: 0x06004113 RID: 16659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003646")]
	[Address(RVA = "0x2059A60", Offset = "0x2059B61", VA = "0x2059A60")]
	public HUDPlayerBuffIcon()
	{
	}

	// Token: 0x04009FCE RID: 40910
	[Token(Token = "0x4007881")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image FoodIconImage;

	// Token: 0x04009FCF RID: 40911
	[Token(Token = "0x4007882")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image OnsenIconImage;

	// Token: 0x04009FD0 RID: 40912
	[Token(Token = "0x4007883")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image VaccineIconImage;

	// Token: 0x04009FD1 RID: 40913
	[Token(Token = "0x4007884")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image HandCuffIconImage;

	// Token: 0x04009FD2 RID: 40914
	[Token(Token = "0x4007885")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform[] SubBuffPos;

	// Token: 0x04009FD3 RID: 40915
	[Token(Token = "0x4007886")]
	[FieldOffset(Offset = "0x40")]
	private bool foodStat;

	// Token: 0x04009FD4 RID: 40916
	[Token(Token = "0x4007887")]
	[FieldOffset(Offset = "0x41")]
	private bool onsenStat;

	// Token: 0x04009FD5 RID: 40917
	[Token(Token = "0x4007888")]
	[FieldOffset(Offset = "0x42")]
	private bool vacStat;

	// Token: 0x04009FD6 RID: 40918
	[Token(Token = "0x4007889")]
	[FieldOffset(Offset = "0x43")]
	private bool handcuffStat;

	// Token: 0x04009FD7 RID: 40919
	[Token(Token = "0x400788A")]
	[FieldOffset(Offset = "0x48")]
	private HumanStatus humanStatus;
}
