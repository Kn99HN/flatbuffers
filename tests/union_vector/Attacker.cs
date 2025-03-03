// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Attacker : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_4(); }
  public static Attacker GetRootAsAttacker(ByteBuffer _bb) { return GetRootAsAttacker(_bb, new Attacker()); }
  public static Attacker GetRootAsAttacker(ByteBuffer _bb, Attacker obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Attacker __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int SwordAttackDamage { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool MutateSwordAttackDamage(int sword_attack_damage) { int o = __p.__offset(4); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, sword_attack_damage); return true; } else { return false; } }

  public static Offset<Attacker> CreateAttacker(FlatBufferBuilder builder,
      int sword_attack_damage = 0) {
    builder.StartTable(1);
    Attacker.AddSwordAttackDamage(builder, sword_attack_damage);
    return Attacker.EndAttacker(builder);
  }

  public static void StartAttacker(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddSwordAttackDamage(FlatBufferBuilder builder, int swordAttackDamage) { builder.AddInt(0, swordAttackDamage, 0); }
  public static Offset<Attacker> EndAttacker(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Attacker>(o);
  }
  public AttackerT UnPack() {
    var _o = new AttackerT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AttackerT _o) {
    _o.SwordAttackDamage = this.SwordAttackDamage;
  }
  public static Offset<Attacker> Pack(FlatBufferBuilder builder, AttackerT _o) {
    if (_o == null) return default(Offset<Attacker>);
    return CreateAttacker(
      builder,
      _o.SwordAttackDamage);
  }
}

public class AttackerT
{
  [Newtonsoft.Json.JsonProperty("sword_attack_damage")]
  public int SwordAttackDamage { get; set; }

  public AttackerT() {
    this.SwordAttackDamage = 0;
  }
}

