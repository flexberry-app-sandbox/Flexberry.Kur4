package Kur4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Kur4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: РегистрБлюд
 */
@Entity(name = "IISKur4РегистрБлюд")
@Table(schema = "public", name = "РегистрБлюд")
public class RegistrBlyud {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "КодБлюда")
    private Integer кодблюда;

    @Column(name = "Наименование")
    private String наименование;

    @Column(name = "Количество")
    private Integer количество;

    @Column(name = "Цена")
    private Integer цена;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Pitanie")
    @Convert("Pitanie")
    @Column(name = "Питание", length = 16, unique = true, nullable = false)
    private UUID _pitanieid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Pitanie", insertable = false, updatable = false)
    private Pitanie pitanie;


    public RegistrBlyud() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Integer getКодБлюда() {
      return кодблюда;
    }

    public void setКодБлюда(Integer кодблюда) {
      this.кодблюда = кодблюда;
    }

    public String getНаименование() {
      return наименование;
    }

    public void setНаименование(String наименование) {
      this.наименование = наименование;
    }

    public Integer getКоличество() {
      return количество;
    }

    public void setКоличество(Integer количество) {
      this.количество = количество;
    }

    public Integer getЦена() {
      return цена;
    }

    public void setЦена(Integer цена) {
      this.цена = цена;
    }


}