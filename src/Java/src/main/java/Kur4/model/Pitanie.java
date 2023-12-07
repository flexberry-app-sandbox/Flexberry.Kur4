package Kur4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Kur4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import java.util.List;

/**
 * Entity implementation class for Entity: Питание
 */
@Entity(name = "IISKur4Питание")
@Table(schema = "public", name = "Питание")
public class Pitanie {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "КодПитания")
    private Integer кодпитания;

    @Column(name = "ВидПитания")
    private String видпитания;

    @OneToMany(mappedBy = "pitanie", fetch = FetchType.LAZY, cascade = CascadeType.REMOVE)
    private List<RegistrBlyud> registrblyuds;


    public Pitanie() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Integer getКодПитания() {
      return кодпитания;
    }

    public void setКодПитания(Integer кодпитания) {
      this.кодпитания = кодпитания;
    }

    public String getВидПитания() {
      return видпитания;
    }

    public void setВидПитания(String видпитания) {
      this.видпитания = видпитания;
    }


}