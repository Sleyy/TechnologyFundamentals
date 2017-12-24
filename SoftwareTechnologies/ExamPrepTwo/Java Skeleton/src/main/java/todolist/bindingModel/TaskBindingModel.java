package todolist.bindingModel;

import org.hibernate.validator.constraints.Length;

import javax.persistence.Column;

public class TaskBindingModel {

    private String title;

    private String comments;


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
