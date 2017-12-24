package todolist.entity;

import org.hibernate.validator.constraints.Length;

import javax.persistence.*;

@Entity
@Table(name = "tasks")
public class Task {

    private Integer Id;

	private String title;

	private String comments;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
	public Integer getId() {
        return Id;
    }


    public void setId(Integer id) {
        Id = id;
    }

    @Column(nullable = false)
    @Length(min = 1)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(nullable = false)
    @Length(min = 1)
    public String getComments() {
        return comments;
    }

    public void setComments(String comments) {
        this.comments = comments;
    }
}
