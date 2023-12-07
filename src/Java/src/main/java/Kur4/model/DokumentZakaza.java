package Kur4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Kur4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;
import java.util.Date;

/**
 * Entity implementation class for Entity: ДокументЗаказа
 */
@Entity(name = "IISKur4ДокументЗаказа")
@Table(schema = "public", name = "ДокументЗаказа")
public class DokumentZakaza {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "КодДокумента")
    private Integer коддокумента;

    @Column(name = "ДатаДокумента")
    private Date датадокумента;

    @Column(name = "Сумма")
    private Integer сумма;

    @Column(name = "ЗаказСобран")
    private Boolean заказсобран;

    @Column(name = "ЗаказОтправ")
    private Boolean заказотправ;

    @Column(name = "ЗаказПолучен")
    private Boolean заказполучен;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Pitanie")
    @Convert("Pitanie")
    @Column(name = "Питание", length = 16, unique = true, nullable = false)
    private UUID _pitanieid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Pitanie", insertable = false, updatable = false)
    private Pitanie pitanie;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Kontragenty")
    @Convert("Kontragenty")
    @Column(name = "Контрагенты", length = 16, unique = true, nullable = false)
    private UUID _kontragentyid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Kontragenty", insertable = false, updatable = false)
    private Kontragenty kontragenty;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Sotrudniki")
    @Convert("Sotrudniki")
    @Column(name = "Сотрудники", length = 16, unique = true, nullable = false)
    private UUID _sotrudnikiid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Sotrudniki", insertable = false, updatable = false)
    private Sotrudniki sotrudniki;


    public DokumentZakaza() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Integer getКодДокумента() {
      return коддокумента;
    }

    public void setКодДокумента(Integer коддокумента) {
      this.коддокумента = коддокумента;
    }

    public Date getДатаДокумента() {
      return датадокумента;
    }

    public void setДатаДокумента(Date датадокумента) {
      this.датадокумента = датадокумента;
    }

    public Integer getСумма() {
      return сумма;
    }

    public void setСумма(Integer сумма) {
      this.сумма = сумма;
    }

    public Boolean getЗаказСобран() {
      return заказсобран;
    }

    public void setЗаказСобран(Boolean заказсобран) {
      this.заказсобран = заказсобран;
    }

    public Boolean getЗаказОтправ() {
      return заказотправ;
    }

    public void setЗаказОтправ(Boolean заказотправ) {
      this.заказотправ = заказотправ;
    }

    public Boolean getЗаказПолучен() {
      return заказполучен;
    }

    public void setЗаказПолучен(Boolean заказполучен) {
      this.заказполучен = заказполучен;
    }


}