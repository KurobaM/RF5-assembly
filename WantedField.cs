using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007C5 RID: 1989
[Token(Token = "0x2000531")]
public class WantedField : MonoBehaviour
{
	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x0600332F RID: 13103 RVA: 0x000118C8 File Offset: 0x0000FAC8
	// (set) Token: 0x06003330 RID: 13104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700058D")]
	public WantedFieldType FieldType
	{
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x1E4C1B0", Offset = "0x1E4C2B1", VA = "0x1E4C1B0")]
		get
		{
			return WantedFieldType.Forest;
		}
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x1E4C1C0", Offset = "0x1E4C2C1", VA = "0x1E4C1C0")]
		private set
		{
		}
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x000118E0 File Offset: 0x0000FAE0
	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x1E4C1D0", Offset = "0x1E4C2D1", VA = "0x1E4C1D0")]
	private int FieldIDToIndex(int fieldID)
	{
		return 0;
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x1E4C1E0", Offset = "0x1E4C2E1", VA = "0x1E4C1E0")]
	public Transform GetPopPoint(int fieldID, int popPointID)
	{
		return null;
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x1E4C330", Offset = "0x1E4C431", VA = "0x1E4C330")]
	public Transform GetPopPoint(int fieldID)
	{
		return null;
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x1E4C410", Offset = "0x1E4C511", VA = "0x1E4C410")]
	public WantedField()
	{
	}

	// Token: 0x040077B6 RID: 30646
	[Token(Token = "0x4006CE3")]
	public const int MaxFieldIDCount = 5;

	// Token: 0x040077B7 RID: 30647
	[Token(Token = "0x4006CE4")]
	public const int MaxPopPointIDCount = 3;

	// Token: 0x040077B8 RID: 30648
	[Token(Token = "0x4006CE5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private WantedFieldType _FieldType;

	// Token: 0x040077B9 RID: 30649
	[Token(Token = "0x4006CE6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<WantedField.Points> FieldPopPointData;

	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x200121A")]
	[Serializable]
	public class Points
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x17000D4B")]
		public int Max
		{
			[Token(Token = "0x6007392")]
			[Address(RVA = "0x1E4C420", Offset = "0x1E4C521", VA = "0x1E4C420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007393")]
		[Address(RVA = "0x1E4C480", Offset = "0x1E4C581", VA = "0x1E4C480")]
		public Points(int max)
		{
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007394")]
		[Address(RVA = "0x1E4C550", Offset = "0x1E4C651", VA = "0x1E4C550")]
		public void Set(int index, Transform point)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007395")]
		[Address(RVA = "0x1E4C2B0", Offset = "0x1E4C3B1", VA = "0x1E4C2B0")]
		public Transform Get(int index)
		{
			return null;
		}

		// Token: 0x040077BA RID: 30650
		[Token(Token = "0x401973C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Transform> List;
	}
}
