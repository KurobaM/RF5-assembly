using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F1 RID: 1265
[Token(Token = "0x200039C")]
public class BeanController : MonoBehaviour, IPooledObejct
{
	// Token: 0x06001F03 RID: 7939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x2208440", Offset = "0x2208541", VA = "0x2208440", Slot = "4")]
	public void OnObjectSpawn()
	{
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x2208570", Offset = "0x2208671", VA = "0x2208570")]
	private void Update()
	{
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x22085F0", Offset = "0x22086F1", VA = "0x22085F0")]
	private void UpdateBean()
	{
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x22088D0", Offset = "0x22089D1", VA = "0x22088D0")]
	public void SetDirection(Vector3 _direction)
	{
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x22088E0", Offset = "0x22089E1", VA = "0x22088E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x22087B0", Offset = "0x22088B1", VA = "0x22087B0")]
	private void UpdateCollided()
	{
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x2208AA0", Offset = "0x2208BA1", VA = "0x2208AA0")]
	public BeanController()
	{
	}

	// Token: 0x040065DE RID: 26078
	[Token(Token = "0x4006057")]
	private const string OUTER_WALL = "OuterWallCube";

	// Token: 0x040065DF RID: 26079
	[Token(Token = "0x4006058")]
	private const string PLAYER_TAG = "Player";

	// Token: 0x040065E0 RID: 26080
	[Token(Token = "0x4006059")]
	private const float ROTATE_SPEED = 360f;

	// Token: 0x040065E1 RID: 26081
	[Token(Token = "0x400605A")]
	private const float FADE_SPEED = 0.5f;

	// Token: 0x040065E2 RID: 26082
	[Token(Token = "0x400605B")]
	[FieldOffset(Offset = "0x18")]
	private bool firstBoot;

	// Token: 0x040065E3 RID: 26083
	[Token(Token = "0x400605C")]
	[FieldOffset(Offset = "0x19")]
	private bool isCollided;

	// Token: 0x040065E4 RID: 26084
	[Token(Token = "0x400605D")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 direction;

	// Token: 0x040065E5 RID: 26085
	[Token(Token = "0x400605E")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	// Token: 0x040065E6 RID: 26086
	[Token(Token = "0x400605F")]
	[FieldOffset(Offset = "0x30")]
	private BoxCollider boxCollider;

	// Token: 0x040065E7 RID: 26087
	[Token(Token = "0x4006060")]
	[FieldOffset(Offset = "0x38")]
	private Material material;

	// Token: 0x040065E8 RID: 26088
	[Token(Token = "0x4006061")]
	[FieldOffset(Offset = "0x40")]
	private float timeCount;

	// Token: 0x040065E9 RID: 26089
	[Token(Token = "0x4006062")]
	[FieldOffset(Offset = "0x44")]
	private float alpha;
}
