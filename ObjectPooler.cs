using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000527 RID: 1319
[Token(Token = "0x20003C1")]
public class ObjectPooler : MonoBehaviour
{
	// Token: 0x06002001 RID: 8193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x1F56B90", Offset = "0x1F56C91", VA = "0x1F56B90")]
	public void Setup()
	{
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x1F56EA0", Offset = "0x1F56FA1", VA = "0x1F56EA0")]
	public GameObject GetObjectFromPool(string _tag)
	{
		return null;
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x1F57260", Offset = "0x1F57361", VA = "0x1F57260")]
	public void ResetObject(string _tag)
	{
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x1F57400", Offset = "0x1F57501", VA = "0x1F57400")]
	public void Clear()
	{
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x1F574A0", Offset = "0x1F575A1", VA = "0x1F574A0")]
	public ObjectPooler()
	{
	}

	// Token: 0x040066E4 RID: 26340
	[Token(Token = "0x4006110")]
	[FieldOffset(Offset = "0x18")]
	public List<ObjectPooler.Pool> PoolList;

	// Token: 0x040066E5 RID: 26341
	[Token(Token = "0x4006111")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, List<GameObject>> poolDictionary;

	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x20010EF")]
	[Serializable]
	public class Pool
	{
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB1")]
		public string Tag
		{
			[Token(Token = "0x6006FAB")]
			[Address(RVA = "0x1F57520", Offset = "0x1F57621", VA = "0x1F57520")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB2")]
		public GameObject Prefab
		{
			[Token(Token = "0x6006FAC")]
			[Address(RVA = "0x1F57530", Offset = "0x1F57631", VA = "0x1F57530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x17000CB3")]
		public int Size
		{
			[Token(Token = "0x6006FAD")]
			[Address(RVA = "0x1F57540", Offset = "0x1F57641", VA = "0x1F57540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAE")]
		[Address(RVA = "0x1F57550", Offset = "0x1F57651", VA = "0x1F57550")]
		public Pool(string _tag, GameObject _prefab, int _size)
		{
		}

		// Token: 0x040066E6 RID: 26342
		[Token(Token = "0x4019247")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string tag;

		// Token: 0x040066E7 RID: 26343
		[Token(Token = "0x4019248")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject prefab;

		// Token: 0x040066E8 RID: 26344
		[Token(Token = "0x4019249")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int size;
	}
}
