using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001146 RID: 4422
	[Token(Token = "0x2000B1E")]
	public class FieldTreasureBoxSpawner : MonoBehaviour
	{
		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x00026B80 File Offset: 0x00024D80
		// (set) Token: 0x0600703B RID: 28731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1A")]
		public bool IsInit
		{
			[Token(Token = "0x6005D01")]
			[Address(RVA = "0x1F91AA0", Offset = "0x1F91BA1", VA = "0x1F91AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF310", Offset = "0x1AF411")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D02")]
			[Address(RVA = "0x1F91AB0", Offset = "0x1F91BB1", VA = "0x1F91AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF320", Offset = "0x1AF421")]
			set
			{
			}
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D03")]
		[Address(RVA = "0x1F91AC0", Offset = "0x1F91BC1", VA = "0x1F91AC0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x1F91AE0", Offset = "0x1F91BE1", VA = "0x1F91AE0", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D05")]
		[Address(RVA = "0x1F91B00", Offset = "0x1F91C01", VA = "0x1F91B00", Slot = "6")]
		public virtual void Spawn()
		{
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D06")]
		[Address(RVA = "0x1F88930", Offset = "0x1F88A31", VA = "0x1F88930")]
		public FieldTreasureBoxSpawner()
		{
		}

		// Token: 0x0401829B RID: 98971
		[Token(Token = "0x4014D0F")]
		[FieldOffset(Offset = "0x18")]
		protected int BoxSpawnID;

		// Token: 0x0401829C RID: 98972
		[Token(Token = "0x4014D10")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string GateDataIDName;

		// Token: 0x0401829D RID: 98973
		[Token(Token = "0x4014D11")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HideInInspector", RVA = "0x1816C0", Offset = "0x1817C1")]
		public GateDataID GateDataID;

		// Token: 0x0401829E RID: 98974
		[Token(Token = "0x4014D12")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpawnObject;

		// Token: 0x0401829F RID: 98975
		[Token(Token = "0x4014D13")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1816D0", Offset = "0x1817D1")]
		private bool <IsInit>k__BackingField;
	}
}
