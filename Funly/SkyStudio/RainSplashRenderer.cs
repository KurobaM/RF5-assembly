using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x200093E")]
	public class RainSplashRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06005DDA RID: 24026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x23DBD30", Offset = "0x23DBE31", VA = "0x23DBD30")]
		private void Start()
		{
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x0001F200 File Offset: 0x0001D400
		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x23DBE60", Offset = "0x23DBF61", VA = "0x23DBE60", Slot = "4")]
		protected override Bounds CalculateMeshBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x23DBE80", Offset = "0x23DBF81", VA = "0x23DBE80", Slot = "5")]
		protected override BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x0001F218 File Offset: 0x0001D418
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x23DBEF0", Offset = "0x23DBFF1", VA = "0x23DBEF0", Slot = "6")]
		protected override bool IsRenderingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x0001F230 File Offset: 0x0001D430
		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x23DC010", Offset = "0x23DC111", VA = "0x23DC010", Slot = "7")]
		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x23DC070", Offset = "0x23DC171", VA = "0x23DC070", Slot = "8")]
		protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x23DC180", Offset = "0x23DC281", VA = "0x23DC180", Slot = "9")]
		protected override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x23DC360", Offset = "0x23DC461", VA = "0x23DC360", Slot = "10")]
		protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x23DC4E0", Offset = "0x23DC5E1", VA = "0x23DC4E0", Slot = "11")]
		protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x23DBBA0", Offset = "0x23DBCA1", VA = "0x23DBBA0")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style)
		{
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x23DC5D0", Offset = "0x23DC6D1", VA = "0x23DC5D0")]
		private void SyncDataFromSkyProfile()
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x0001F248 File Offset: 0x0001D448
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x23DC1D0", Offset = "0x23DC2D1", VA = "0x23DC1D0")]
		private Vector3 CreateWorldSplashPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x23DC830", Offset = "0x23DC931", VA = "0x23DC830")]
		public RainSplashRenderer()
		{
		}

		// Token: 0x0400BDDB RID: 48603
		[Token(Token = "0x4008E3F")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_DepthCamera;

		// Token: 0x0400BDDC RID: 48604
		[Token(Token = "0x4008E40")]
		[FieldOffset(Offset = "0x90")]
		private float[] m_StartSplashYPositions;

		// Token: 0x0400BDDD RID: 48605
		[Token(Token = "0x4008E41")]
		[FieldOffset(Offset = "0x98")]
		private float[] m_DepthUs;

		// Token: 0x0400BDDE RID: 48606
		[Token(Token = "0x4008E42")]
		[FieldOffset(Offset = "0xA0")]
		private float[] m_DepthVs;

		// Token: 0x0400BDDF RID: 48607
		[Token(Token = "0x4008E43")]
		[FieldOffset(Offset = "0xA8")]
		private float m_SplashAreaStart;

		// Token: 0x0400BDE0 RID: 48608
		[Token(Token = "0x4008E44")]
		[FieldOffset(Offset = "0xAC")]
		private float m_SplashAreaLength;

		// Token: 0x0400BDE1 RID: 48609
		[Token(Token = "0x4008E45")]
		[FieldOffset(Offset = "0xB0")]
		private float m_SplashScale;

		// Token: 0x0400BDE2 RID: 48610
		[Token(Token = "0x4008E46")]
		[FieldOffset(Offset = "0xB4")]
		private float m_SplashScaleVarience;

		// Token: 0x0400BDE3 RID: 48611
		[Token(Token = "0x4008E47")]
		[FieldOffset(Offset = "0xB8")]
		private float m_SplashItensity;

		// Token: 0x0400BDE4 RID: 48612
		[Token(Token = "0x4008E48")]
		[FieldOffset(Offset = "0xBC")]
		private float m_SplashSurfaceOffset;

		// Token: 0x0400BDE5 RID: 48613
		[Token(Token = "0x4008E49")]
		[FieldOffset(Offset = "0xC0")]
		private SkyProfile m_SkyProfile;

		// Token: 0x0400BDE6 RID: 48614
		[Token(Token = "0x4008E4A")]
		[FieldOffset(Offset = "0xC8")]
		private float m_TimeOfDay;

		// Token: 0x0400BDE7 RID: 48615
		[Token(Token = "0x4008E4B")]
		[FieldOffset(Offset = "0xD0")]
		private RainSplashArtItem m_Style;

		// Token: 0x0400BDE8 RID: 48616
		[Token(Token = "0x4008E4C")]
		[FieldOffset(Offset = "0xD8")]
		private Bounds m_Bounds;
	}
}
