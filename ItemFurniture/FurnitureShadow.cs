using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x0200104E RID: 4174
	[Token(Token = "0x2000A98")]
	public class FurnitureShadow : MonoBehaviour
	{
		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x00023E80 File Offset: 0x00022080
		[Token(Token = "0x17000A83")]
		public bool Hit
		{
			[Token(Token = "0x600577F")]
			[Address(RVA = "0x20805D0", Offset = "0x20806D1", VA = "0x20805D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005780")]
		[Address(RVA = "0x20805E0", Offset = "0x20806E1", VA = "0x20805E0")]
		private void Start()
		{
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005781")]
		[Address(RVA = "0x20806B0", Offset = "0x20807B1", VA = "0x20806B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005782")]
		[Address(RVA = "0x2080D80", Offset = "0x2080E81", VA = "0x2080D80")]
		private void SetAlpha(float alpha, bool red = false)
		{
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005783")]
		[Address(RVA = "0x2080F50", Offset = "0x2081051", VA = "0x2080F50")]
		public void FarmHit(bool hit)
		{
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00023E98 File Offset: 0x00022098
		[Token(Token = "0x6005784")]
		[Address(RVA = "0x2080700", Offset = "0x2080801", VA = "0x2080700")]
		public bool CheckHit()
		{
			return default(bool);
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005785")]
		[Address(RVA = "0x2080D60", Offset = "0x2080E61", VA = "0x2080D60")]
		private void updateDisp()
		{
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005786")]
		[Address(RVA = "0x2080F60", Offset = "0x2081061", VA = "0x2080F60")]
		public void SetCollider(BoxCollider collider, GameObject original)
		{
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005787")]
		[Address(RVA = "0x20815B0", Offset = "0x20816B1", VA = "0x20815B0")]
		public void OnPut()
		{
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005788")]
		[Address(RVA = "0x2081740", Offset = "0x2081841", VA = "0x2081740")]
		public FurnitureShadow()
		{
		}

		// Token: 0x0401713C RID: 94524
		[Token(Token = "0x4013DA2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader shadowShader;

		// Token: 0x0401713D RID: 94525
		[Token(Token = "0x4013DA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180660", Offset = "0x180761")]
		private float shadowAlpha;

		// Token: 0x0401713E RID: 94526
		[Token(Token = "0x4013DA4")]
		[FieldOffset(Offset = "0x28")]
		private BoxCollider box;

		// Token: 0x0401713F RID: 94527
		[Token(Token = "0x4013DA5")]
		[FieldOffset(Offset = "0x30")]
		private bool shadowDisp;

		// Token: 0x04017140 RID: 94528
		[Token(Token = "0x4013DA6")]
		[FieldOffset(Offset = "0x38")]
		private GameObject copied;

		// Token: 0x04017141 RID: 94529
		[Token(Token = "0x4013DA7")]
		[FieldOffset(Offset = "0x40")]
		private bool isActive;

		// Token: 0x04017142 RID: 94530
		[Token(Token = "0x4013DA8")]
		[FieldOffset(Offset = "0x41")]
		private bool isHit;

		// Token: 0x04017143 RID: 94531
		[Token(Token = "0x4013DA9")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] pos_tbl_;

		// Token: 0x04017144 RID: 94532
		[Token(Token = "0x4013DAA")]
		[FieldOffset(Offset = "0x50")]
		private Renderer _renderer;

		// Token: 0x04017145 RID: 94533
		[Token(Token = "0x4013DAB")]
		[FieldOffset(Offset = "0x58")]
		private Material[] _materials;

		// Token: 0x04017146 RID: 94534
		[Token(Token = "0x4013DAC")]
		[FieldOffset(Offset = "0x60")]
		private bool isFarmHit;
	}
}
